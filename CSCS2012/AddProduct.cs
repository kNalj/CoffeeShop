using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CSCS2012
{
    public partial class AddProduct : Form
    {

        private cSharpCoffeeShopDatabaseEntities csde = new cSharpCoffeeShopDatabaseEntities();

        private Byte[] byteData;

        public AddProduct()
        {
            InitializeComponent();

            comboBoxForCategories.DataSource = csde.TblProductTypes.ToList();
            comboBoxForCategories.DisplayMember = "Description"; //ono sta vidis u combo boxu
            comboBoxForCategories.ValueMember = "ProductType"; //vrijednost koju prosljedjujes
        }

        private void buttonUploadImg_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogForUpload.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialogForUpload.FileName, FileMode.Open, FileAccess.Read);
                byteData = new Byte[fs.Length];
                fs.Read(byteData, 0, byteData.Length);
                fs.Close();

                MemoryStream ms = new MemoryStream(byteData);
                pictureBoxForProductImg.Image = Image.FromStream(ms);
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            TblProduct p = new TblProduct();

            p.ProductID = 1;
            p.Description = textBoxForDescription.Text;
            p.Price = decimal.Parse(textBoxForPrice.Text);
            p.Image = byteData;
            p.ProductType = (int)comboBoxForCategories.SelectedValue;

            csde.TblProducts.Add(p);
            csde.SaveChanges();

            MessageBox.Show("Success");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCategory ac = new AddCategory();
            ac.ShowDialog();
            this.Refresh();
        }
    }
}
