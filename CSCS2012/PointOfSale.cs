using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using System.Drawing.Printing;
using System.IO;

namespace CSCS2012
{
    public partial class PointOfSale : Form
    {

        private BindingList<TblProduct> products = new BindingList<TblProduct>();
        private cSharpCoffeeShopDatabaseEntities csde = new cSharpCoffeeShopDatabaseEntities();
        private Byte[] byteData;

        private decimal tabTotal;
        public decimal TabTotal
        {
            get { return tabTotal; }
            set { tabTotal = value; textBoxForTotal.Text = String.Format("{0:c}", tabTotal); }
        }

        public PointOfSale()
        {
            InitializeComponent();

            //products je izvor podataka za pregled racuna
            listBoxForOrder.DataSource = products;
            listBoxForOrder.DisplayMember = "Description";

            populateTabs();
            populateDrinks();
        }

        //generira tabove iz baze podataka
        //za svaki tip koji postoji po jedan tab
        private void populateTabs()
        {
            foreach (TblProductType pt in csde.TblProductTypes)
            {
                tabControlForTypes.TabPages.Add(pt.ProductType.ToString(), pt.Description);
            }
        }

        //generira botune za pića iz baze podataka
        //za svaki tab dobavi sve proizvode koji imaju taj tip
        private void populateDrinks()
        {
            foreach (TabPage tp in tabControlForTypes.TabPages)
            {

                int type = Int32.Parse(tp.Name);
                var productsToAdd = from pta in csde.TblProducts
                                    where pta.ProductType == type
                                    select pta;

                //naziđa mi je sve botune jedan priko drugog pa je ovo neko jednostavno rjesenje za to
                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Dock = DockStyle.Fill;  

                //za svaki proizvod koji je dohvaćen kreiraj botun
                //u tag botuna tutni proizvod da ga moš dobavit posli i tutnit u products
                foreach (TblProduct tblp in productsToAdd)
                {
                    Button b = new Button();
                    b.Size = new Size(110, 110);
                    b.Text = tblp.Description;
                    b.Font = new Font("Tahoma",10,FontStyle.Bold);
                    b.Tag = tblp;

                    byteData = (byte[])tblp.Image;
                    if (byteData != null)
                    {
                        MemoryStream ms = new MemoryStream(byteData);
                        b.BackgroundImage = Image.FromStream(ms);
                    }
                    
                    //klikom na botun trigera se event koji dodaje proizvod u binding listu
                    b.Click +=new EventHandler(AddProductToFinalTab);

                    flp.Controls.Add(b);
                }

                tp.Controls.Add(flp);
            }
        }

        //promini info text
        private void UpdateInfoPanel(TblProduct product)
        {
            textBoxForInfo.Text = product.Description;
        }

        //promini cijenu
        private void UpdatePricePanel(TblProduct product)
        {
            textBoxForPriceInfo.Text = product.Price.ToString();
        }
        

        //dodavanja stavki na pregled racuna
        private void AddProductToFinalTab(object sender, EventArgs e)
        { 
            Button b = (Button)sender;

            TblProduct tp = (TblProduct)b.Tag;

            //HINT -> vidi konstruktor
            products.Add(tp);

            UpdateInfoPanel(tp);
            UpdatePricePanel(tp);

            TabTotal += (decimal)tp.Price;

            listBoxForOrder.SelectedIndex = listBoxForOrder.Items.Count - 1;
        }

        //promini info box kad kliknes na neki item na pregledu racuna
        private void UpdateInfoFromListBox(object sender, EventArgs e)
        {
            TblProduct tp = (TblProduct)listBoxForOrder.SelectedItem;
            if (tp != null)
            {
                UpdateInfoPanel(tp);
                UpdatePricePanel(tp);
            }
        }

        //kako ce izgledat text na pregledu racuna
        private void FormatListItem(object sender, ListControlConvertEventArgs e)
        {
            string desc = ((TblProduct)e.ListItem).Description;
            string price = String.Format("{0:c}",((TblProduct)e.ListItem).Price);
            string final = desc.PadRight(20) + price;

            e.Value = final;
        }

        //brisanje stavki sa pregleda racuna
        private void RemoveItem(object sender, EventArgs e)
        {
            if (products.Count > 0)
            {
                TblProduct selectedProduct = (TblProduct)listBoxForOrder.SelectedItem;
                TabTotal -= (decimal)selectedProduct.Price;
                products.Remove(selectedProduct);
            }
        }

        //generira event za obradu placanja
        private void OpenPay(object sender, EventArgs e)
        {
            Pay pay = new Pay();
            pay.PaymentMade += new Pay.PaymentMadeEvent(pay_PaymentMade);
            pay.Amount = TabTotal;
            pay.ShowDialog();

            //počisti ostatke od prošlog računa
            products.Clear();
        }

        //generira event za printanje racuna
        private void printReceipt()
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument pdc = new PrintDocument();

            pd.Document = pdc;
            pdc.PrintPage +=new PrintPageEventHandler(pdc_PrintPage);

            DialogResult res = pd.ShowDialog();

            if (res == DialogResult.OK)
            {
                pdc.Print();
            }
        }

        //kad je uplata uspjesna sprema sve u bazu
        void pay_PaymentMade(object sender, PaymentMadeEventArgs e)
        {
            TblTransaction t = new TblTransaction();
            t.TransactionDate = DateTime.Today;

            csde.TblTransactions.Add(t);
            csde.SaveChanges();

            if (e.paymentSuccess == true)
            {
                foreach (TblProduct p in products)
                {
                    TblTransactionItem ti = new TblTransactionItem();
                    ti.ProductID = p.ProductID;
                    ti.TransactionID = t.TransactionID;

                    csde.TblTransactionItems.Add(ti);
                    csde.SaveChanges();
                }

                tabTotal = 0;
                printReceipt();
            }
            else
            {
                MessageBox.Show("Error proccessing the playment");
            }
            this.Refresh();
        }

        //iscrtava racun
        void pdc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            Font f = new Font("Courier New", 12);
            float fontHeight = f.GetHeight();

            int x = 10;
            int y = 10;
            int offset = 40;

            g.DrawString("Welcome", new Font("Courier New", 18), new SolidBrush(Color.Black), x, y);

            foreach (TblProduct product in products)
            {
                string productDescription = product.Description.PadRight(30);
                string productTotal = String.Format("{0:c}", product.Price);
                string final = productDescription + productTotal;

                g.DrawString(final, f, new SolidBrush(Color.Black), x, y + offset);
                offset += (int)fontHeight + 5;
            }

            offset += 20;
            g.DrawString("Total:".PadRight(30) + String.Format("{0:c}", TabTotal), f, new SolidBrush(Color.Black), x, y + offset);
        }

    }
}
