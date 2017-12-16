namespace CSCS2012
{
    partial class PointOfSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointOfSale));
            this.listBoxForOrder = new System.Windows.Forms.ListBox();
            this.tabControlForTypes = new System.Windows.Forms.TabControl();
            this.textBoxForInfo = new System.Windows.Forms.TextBox();
            this.textBoxForPriceInfo = new System.Windows.Forms.TextBox();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.buttonForPaying = new System.Windows.Forms.Button();
            this.textBoxForTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxForOrder
            // 
            this.listBoxForOrder.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxForOrder.FormattingEnabled = true;
            this.listBoxForOrder.ItemHeight = 14;
            this.listBoxForOrder.Location = new System.Drawing.Point(398, 13);
            this.listBoxForOrder.Name = "listBoxForOrder";
            this.listBoxForOrder.Size = new System.Drawing.Size(200, 270);
            this.listBoxForOrder.TabIndex = 0;
            this.listBoxForOrder.SelectedIndexChanged += new System.EventHandler(this.UpdateInfoFromListBox);
            this.listBoxForOrder.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.FormatListItem);
            // 
            // tabControlForTypes
            // 
            this.tabControlForTypes.Location = new System.Drawing.Point(12, 58);
            this.tabControlForTypes.Name = "tabControlForTypes";
            this.tabControlForTypes.SelectedIndex = 0;
            this.tabControlForTypes.Size = new System.Drawing.Size(380, 224);
            this.tabControlForTypes.TabIndex = 1;
            // 
            // textBoxForInfo
            // 
            this.textBoxForInfo.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxForInfo.Location = new System.Drawing.Point(12, 13);
            this.textBoxForInfo.Name = "textBoxForInfo";
            this.textBoxForInfo.Size = new System.Drawing.Size(266, 31);
            this.textBoxForInfo.TabIndex = 2;
            // 
            // textBoxForPriceInfo
            // 
            this.textBoxForPriceInfo.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxForPriceInfo.Location = new System.Drawing.Point(297, 11);
            this.textBoxForPriceInfo.Name = "textBoxForPriceInfo";
            this.textBoxForPriceInfo.Size = new System.Drawing.Size(94, 31);
            this.textBoxForPriceInfo.TabIndex = 3;
            this.textBoxForPriceInfo.Text = "0.0";
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.Location = new System.Drawing.Point(398, 290);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(75, 40);
            this.buttonRemoveItem.TabIndex = 4;
            this.buttonRemoveItem.Text = "Remove";
            this.buttonRemoveItem.UseVisualStyleBackColor = true;
            this.buttonRemoveItem.Click += new System.EventHandler(this.RemoveItem);
            // 
            // buttonForPaying
            // 
            this.buttonForPaying.Location = new System.Drawing.Point(297, 288);
            this.buttonForPaying.Name = "buttonForPaying";
            this.buttonForPaying.Size = new System.Drawing.Size(93, 41);
            this.buttonForPaying.TabIndex = 5;
            this.buttonForPaying.Text = "Pay";
            this.buttonForPaying.UseVisualStyleBackColor = true;
            this.buttonForPaying.Click += new System.EventHandler(this.OpenPay);
            // 
            // textBoxForTotal
            // 
            this.textBoxForTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxForTotal.Location = new System.Drawing.Point(479, 292);
            this.textBoxForTotal.Name = "textBoxForTotal";
            this.textBoxForTotal.Size = new System.Drawing.Size(118, 35);
            this.textBoxForTotal.TabIndex = 6;
            // 
            // PointOfSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSCS2012.Properties.Resources.coffee_beans_926837_640;
            this.ClientSize = new System.Drawing.Size(610, 342);
            this.Controls.Add(this.textBoxForTotal);
            this.Controls.Add(this.buttonForPaying);
            this.Controls.Add(this.buttonRemoveItem);
            this.Controls.Add(this.textBoxForPriceInfo);
            this.Controls.Add(this.textBoxForInfo);
            this.Controls.Add(this.tabControlForTypes);
            this.Controls.Add(this.listBoxForOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PointOfSale";
            this.Text = "POS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxForOrder;
        private System.Windows.Forms.TabControl tabControlForTypes;
        private System.Windows.Forms.TextBox textBoxForInfo;
        private System.Windows.Forms.TextBox textBoxForPriceInfo;
        private System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.Button buttonForPaying;
        private System.Windows.Forms.TextBox textBoxForTotal;
    }
}