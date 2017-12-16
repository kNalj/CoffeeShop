using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;

namespace CSCS2012
{
    public partial class ViewProducts : Form
    {

        private cSharpCoffeeShopDatabaseEntities csde = new cSharpCoffeeShopDatabaseEntities();

        public ViewProducts()
        {
            InitializeComponent();

            dataGridView1.DataSource = csde.TblProducts.ToList();

            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            
            comboBoxForListFilter.DataSource = csde.TblProductTypes.ToList();
            comboBoxForListFilter.DisplayMember = "Description";
            comboBoxForListFilter.ValueMember = "ProductType";
        }

        private void FilterList(object sender, EventArgs e)
        {

            int type = (int)comboBoxForListFilter.SelectedValue;
            var filteredProducts = from product in csde.TblProducts
                                   where product.ProductType == type
                                   select product;

            dataGridView1.DataSource = filteredProducts.ToList();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var itemToRemove = (from product in csde.TblProducts
                               where product.ProductID == id
                               select product).FirstOrDefault();

            csde.TblProducts.Remove(itemToRemove);
            csde.SaveChanges();
        }*/

    }
}
