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
    public partial class Statistics : Form
    {

        private cSharpCoffeeShopDatabaseEntities csde = new cSharpCoffeeShopDatabaseEntities();

        public Statistics()
        {
            InitializeComponent();

            dataGridViewStats.DataSource = csde.TblTransactions.ToList();
            dataGridViewStats.Columns[2].Visible = false;
            
        }

        private void dataGridViewStats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            listBox1.Items.Clear();

            int transID = (int)dataGridViewStats.SelectedRows[0].Cells[0].Value;

            var transactionItems = from ti in csde.TblTransactionItems
                           where ti.TransactionID == transID
                           select ti;


            foreach (TblTransactionItem item in transactionItems)
            {

                var products = from product in csde.TblProducts
                               where product.ProductID == item.ProductID
                               select product;

                listBox1.Items.Add(products.First().Description);
            }
        }

        private void filterByDate(object sender, EventArgs e)
        {

            int day = dateTimePickerForProductsByDates.Value.Day;
            int month = dateTimePickerForProductsByDates.Value.Month;
            int year = dateTimePickerForProductsByDates.Value.Year;

            var transactions = from transaction in csde.TblTransactions
                               where transaction.TransactionDate.Value.Day == day
                               && transaction.TransactionDate.Value.Month == month
                               && transaction.TransactionDate.Value.Year == year
                                select transaction;

            foreach (TblTransaction transaction in transactions)
            {

                var items = from item in csde.TblTransactionItems
                               where item.TransactionID == transaction.TransactionID
                               select item;

                foreach (TblTransactionItem item in items)
                {

                    var products = from product in csde.TblProducts
                                   where product.ProductID == item.ProductID
                                   select product;

                    listBoxForProductsByDates.Items.Add(products.First().Description);
                    
                }
            }
        }
    }
}
