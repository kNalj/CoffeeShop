namespace CSCS2012
{
    partial class Statistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.dataGridViewStats = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControlForReceipts = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxForProductsByDates = new System.Windows.Forms.ListBox();
            this.dateTimePickerForProductsByDates = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStats)).BeginInit();
            this.tabControlForReceipts.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStats
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStats.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStats.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewStats.Name = "dataGridViewStats";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStats.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStats.Size = new System.Drawing.Size(377, 342);
            this.dataGridViewStats.TabIndex = 0;
            this.dataGridViewStats.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStats_CellClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(389, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 342);
            this.listBox1.TabIndex = 3;
            // 
            // tabControlForReceipts
            // 
            this.tabControlForReceipts.Controls.Add(this.tabPage1);
            this.tabControlForReceipts.Controls.Add(this.tabPage2);
            this.tabControlForReceipts.Location = new System.Drawing.Point(12, 12);
            this.tabControlForReceipts.Name = "tabControlForReceipts";
            this.tabControlForReceipts.SelectedIndex = 0;
            this.tabControlForReceipts.Size = new System.Drawing.Size(629, 383);
            this.tabControlForReceipts.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewStats);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(621, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Računi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxForProductsByDates);
            this.tabPage2.Controls.Add(this.dateTimePickerForProductsByDates);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(621, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dani";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxForProductsByDates
            // 
            this.listBoxForProductsByDates.FormattingEnabled = true;
            this.listBoxForProductsByDates.Location = new System.Drawing.Point(-4, 25);
            this.listBoxForProductsByDates.Name = "listBoxForProductsByDates";
            this.listBoxForProductsByDates.Size = new System.Drawing.Size(624, 329);
            this.listBoxForProductsByDates.TabIndex = 1;
            // 
            // dateTimePickerForProductsByDates
            // 
            this.dateTimePickerForProductsByDates.Location = new System.Drawing.Point(205, 6);
            this.dateTimePickerForProductsByDates.Name = "dateTimePickerForProductsByDates";
            this.dateTimePickerForProductsByDates.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerForProductsByDates.TabIndex = 0;
            this.dateTimePickerForProductsByDates.ValueChanged += new System.EventHandler(this.filterByDate);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 412);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(378, 412);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 20);
            this.textBox2.TabIndex = 6;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSCS2012.Properties.Resources.coffee_beans_926837_640;
            this.ClientSize = new System.Drawing.Size(674, 464);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControlForReceipts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStats)).EndInit();
            this.tabControlForReceipts.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStats;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControlForReceipts;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxForProductsByDates;
        private System.Windows.Forms.DateTimePicker dateTimePickerForProductsByDates;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;

    }
}