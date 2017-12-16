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
    public partial class Pay : Form
    {

        private decimal amount;

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; textBoxForTotalPrice.Text = amount.ToString(); }
        }

        public delegate void PaymentMadeEvent(object sender, PaymentMadeEventArgs e);

        public event PaymentMadeEvent PaymentMade;

        public Pay()
        {
            InitializeComponent();
        }

        private void PaymentWasMade(object sender, EventArgs e)
        {
            decimal total = 0;

            try
            {
                total = decimal.Parse(textBoxForTotalPrice.Text) - decimal.Parse(textBoxForRecieved.Text);
            }
            catch
            {
                MessageBox.Show("Error !");
                textBoxForRecieved.Text = "";
                return;
            }

            if (total > 0)
            {
                textBoxForTotalPrice.Text = total.ToString();
            }
            else
            { 
                MessageBox.Show("Change to be returned: " + String.Format("{0:c}",-total));
                PaymentMade(this, new PaymentMadeEventArgs() { paymentSuccess = true });
                this.Close();
            }
        }
    }

    public class PaymentMadeEventArgs : EventArgs
    {
        public bool paymentSuccess;
    }
}
