using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSCS2012
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewProducts viewProducts = new ViewProducts();
            viewProducts.Show();
        }

        private void buttonForPOS_Click(object sender, EventArgs e)
        {
            PointOfSale POS = new PointOfSale();

            POS.Show();
        }

        private void buttonForStats_Click(object sender, EventArgs e)
        {
            Statistics stats = new Statistics();
            stats.Show();
        }

    }
}
