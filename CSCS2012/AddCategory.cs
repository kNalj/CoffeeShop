using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCS2012
{
    public partial class AddCategory : Form
    {

        private cSharpCoffeeShopDatabaseEntities csde = new cSharpCoffeeShopDatabaseEntities();

        public AddCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TblProductType pt = new TblProductType();

            pt.Description = textBoxForNewCategory.Text;

            csde.TblProductTypes.Add(pt);
            csde.SaveChanges();

            MessageBox.Show("Success");
            this.Close();
        }

    }
}
