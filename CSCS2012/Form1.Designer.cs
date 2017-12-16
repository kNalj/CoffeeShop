namespace CSCS2012
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonForListView = new System.Windows.Forms.Button();
            this.buttonForAdd = new System.Windows.Forms.Button();
            this.buttonForPOS = new System.Windows.Forms.Button();
            this.buttonForAddingItems = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonForStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonForListView
            // 
            this.buttonForListView.BackgroundImage = global::CSCS2012.Properties.Resources.ViewAll;
            this.buttonForListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonForListView.Location = new System.Drawing.Point(12, 215);
            this.buttonForListView.Name = "buttonForListView";
            this.buttonForListView.Size = new System.Drawing.Size(201, 190);
            this.buttonForListView.TabIndex = 1;
            this.buttonForListView.Text = "List";
            this.buttonForListView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonForListView.UseVisualStyleBackColor = true;
            this.buttonForListView.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonForAdd
            // 
            this.buttonForAdd.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonForAdd.BackgroundImage = global::CSCS2012.Properties.Resources.AddNew;
            this.buttonForAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonForAdd.Location = new System.Drawing.Point(12, 12);
            this.buttonForAdd.Name = "buttonForAdd";
            this.buttonForAdd.Size = new System.Drawing.Size(201, 190);
            this.buttonForAdd.TabIndex = 0;
            this.buttonForAdd.Text = "Add";
            this.buttonForAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonForAdd.UseVisualStyleBackColor = false;
            this.buttonForAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonForPOS
            // 
            this.buttonForPOS.BackgroundImage = global::CSCS2012.Properties.Resources.POS;
            this.buttonForPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonForPOS.Location = new System.Drawing.Point(257, 12);
            this.buttonForPOS.Name = "buttonForPOS";
            this.buttonForPOS.Size = new System.Drawing.Size(285, 190);
            this.buttonForPOS.TabIndex = 2;
            this.buttonForPOS.Text = "POS";
            this.buttonForPOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonForPOS.UseVisualStyleBackColor = true;
            this.buttonForPOS.Click += new System.EventHandler(this.buttonForPOS_Click);
            // 
            // buttonForAddingItems
            // 
            this.buttonForAddingItems.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonForAddingItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonForAddingItems.Location = new System.Drawing.Point(12, 12);
            this.buttonForAddingItems.Name = "buttonForAddingItems";
            this.buttonForAddingItems.Size = new System.Drawing.Size(201, 190);
            this.buttonForAddingItems.TabIndex = 0;
            this.buttonForAddingItems.Text = "Add";
            this.buttonForAddingItems.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonForAddingItems.UseVisualStyleBackColor = false;
            this.buttonForAddingItems.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(12, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 190);
            this.button2.TabIndex = 1;
            this.button2.Text = "List";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonForStats
            // 
            this.buttonForStats.BackgroundImage = global::CSCS2012.Properties.Resources.stats;
            this.buttonForStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonForStats.Location = new System.Drawing.Point(257, 215);
            this.buttonForStats.Name = "buttonForStats";
            this.buttonForStats.Size = new System.Drawing.Size(285, 189);
            this.buttonForStats.TabIndex = 3;
            this.buttonForStats.Text = "Stats";
            this.buttonForStats.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonForStats.UseVisualStyleBackColor = true;
            this.buttonForStats.Click += new System.EventHandler(this.buttonForStats_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSCS2012.Properties.Resources.coffee_beans_926837_640;
            this.ClientSize = new System.Drawing.Size(554, 417);
            this.Controls.Add(this.buttonForStats);
            this.Controls.Add(this.buttonForPOS);
            this.Controls.Add(this.buttonForListView);
            this.Controls.Add(this.buttonForAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonForAdd;
        private System.Windows.Forms.Button buttonForListView;
        private System.Windows.Forms.Button buttonForPOS;
        private System.Windows.Forms.Button buttonForAddingItems;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonForStats;
    }
}

