namespace CSCS2012
{
    partial class Pay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay));
            this.labelForTotal = new System.Windows.Forms.Label();
            this.labelForRecieved = new System.Windows.Forms.Label();
            this.textBoxForTotalPrice = new System.Windows.Forms.TextBox();
            this.textBoxForRecieved = new System.Windows.Forms.TextBox();
            this.buttonForPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelForTotal
            // 
            this.labelForTotal.AutoSize = true;
            this.labelForTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelForTotal.ForeColor = System.Drawing.Color.White;
            this.labelForTotal.Location = new System.Drawing.Point(4, 13);
            this.labelForTotal.Name = "labelForTotal";
            this.labelForTotal.Size = new System.Drawing.Size(31, 13);
            this.labelForTotal.TabIndex = 0;
            this.labelForTotal.Text = "Total";
            // 
            // labelForRecieved
            // 
            this.labelForRecieved.AutoSize = true;
            this.labelForRecieved.BackColor = System.Drawing.Color.Transparent;
            this.labelForRecieved.ForeColor = System.Drawing.Color.White;
            this.labelForRecieved.Location = new System.Drawing.Point(4, 55);
            this.labelForRecieved.Name = "labelForRecieved";
            this.labelForRecieved.Size = new System.Drawing.Size(53, 13);
            this.labelForRecieved.TabIndex = 1;
            this.labelForRecieved.Text = "Recieved";
            // 
            // textBoxForTotalPrice
            // 
            this.textBoxForTotalPrice.Location = new System.Drawing.Point(63, 10);
            this.textBoxForTotalPrice.Name = "textBoxForTotalPrice";
            this.textBoxForTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxForTotalPrice.TabIndex = 2;
            // 
            // textBoxForRecieved
            // 
            this.textBoxForRecieved.Location = new System.Drawing.Point(63, 52);
            this.textBoxForRecieved.Name = "textBoxForRecieved";
            this.textBoxForRecieved.Size = new System.Drawing.Size(100, 20);
            this.textBoxForRecieved.TabIndex = 3;
            // 
            // buttonForPayment
            // 
            this.buttonForPayment.Location = new System.Drawing.Point(13, 144);
            this.buttonForPayment.Name = "buttonForPayment";
            this.buttonForPayment.Size = new System.Drawing.Size(259, 41);
            this.buttonForPayment.TabIndex = 4;
            this.buttonForPayment.Text = "Pay";
            this.buttonForPayment.UseVisualStyleBackColor = true;
            this.buttonForPayment.Click += new System.EventHandler(this.PaymentWasMade);
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSCS2012.Properties.Resources.coffee_beans_926837_640;
            this.ClientSize = new System.Drawing.Size(284, 197);
            this.Controls.Add(this.buttonForPayment);
            this.Controls.Add(this.textBoxForRecieved);
            this.Controls.Add(this.textBoxForTotalPrice);
            this.Controls.Add(this.labelForRecieved);
            this.Controls.Add(this.labelForTotal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pay";
            this.Text = "Pay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForTotal;
        private System.Windows.Forms.Label labelForRecieved;
        private System.Windows.Forms.TextBox textBoxForTotalPrice;
        private System.Windows.Forms.TextBox textBoxForRecieved;
        private System.Windows.Forms.Button buttonForPayment;
    }
}