namespace CSCS2012
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.labelForDescription = new System.Windows.Forms.Label();
            this.textBoxForDescription = new System.Windows.Forms.TextBox();
            this.textBoxForPrice = new System.Windows.Forms.TextBox();
            this.labelForPrice = new System.Windows.Forms.Label();
            this.labelForCategory = new System.Windows.Forms.Label();
            this.comboBoxForCategories = new System.Windows.Forms.ComboBox();
            this.labelForImg = new System.Windows.Forms.Label();
            this.pictureBoxForProductImg = new System.Windows.Forms.PictureBox();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonUploadImg = new System.Windows.Forms.Button();
            this.openFileDialogForUpload = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForProductImg)).BeginInit();
            this.SuspendLayout();
            // 
            // labelForDescription
            // 
            this.labelForDescription.AutoSize = true;
            this.labelForDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelForDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelForDescription.ForeColor = System.Drawing.Color.White;
            this.labelForDescription.Location = new System.Drawing.Point(12, 69);
            this.labelForDescription.Name = "labelForDescription";
            this.labelForDescription.Size = new System.Drawing.Size(60, 13);
            this.labelForDescription.TabIndex = 0;
            this.labelForDescription.Text = "Description";
            // 
            // textBoxForDescription
            // 
            this.textBoxForDescription.Location = new System.Drawing.Point(100, 69);
            this.textBoxForDescription.Name = "textBoxForDescription";
            this.textBoxForDescription.Size = new System.Drawing.Size(146, 20);
            this.textBoxForDescription.TabIndex = 1;
            // 
            // textBoxForPrice
            // 
            this.textBoxForPrice.Location = new System.Drawing.Point(100, 122);
            this.textBoxForPrice.Name = "textBoxForPrice";
            this.textBoxForPrice.Size = new System.Drawing.Size(146, 20);
            this.textBoxForPrice.TabIndex = 2;
            // 
            // labelForPrice
            // 
            this.labelForPrice.AutoSize = true;
            this.labelForPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelForPrice.ForeColor = System.Drawing.Color.White;
            this.labelForPrice.Location = new System.Drawing.Point(12, 129);
            this.labelForPrice.Name = "labelForPrice";
            this.labelForPrice.Size = new System.Drawing.Size(31, 13);
            this.labelForPrice.TabIndex = 3;
            this.labelForPrice.Text = "Price";
            // 
            // labelForCategory
            // 
            this.labelForCategory.AutoSize = true;
            this.labelForCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelForCategory.ForeColor = System.Drawing.Color.White;
            this.labelForCategory.Location = new System.Drawing.Point(12, 178);
            this.labelForCategory.Name = "labelForCategory";
            this.labelForCategory.Size = new System.Drawing.Size(49, 13);
            this.labelForCategory.TabIndex = 4;
            this.labelForCategory.Text = "Category";
            // 
            // comboBoxForCategories
            // 
            this.comboBoxForCategories.FormattingEnabled = true;
            this.comboBoxForCategories.Location = new System.Drawing.Point(100, 170);
            this.comboBoxForCategories.Name = "comboBoxForCategories";
            this.comboBoxForCategories.Size = new System.Drawing.Size(106, 21);
            this.comboBoxForCategories.TabIndex = 5;
            // 
            // labelForImg
            // 
            this.labelForImg.AutoSize = true;
            this.labelForImg.BackColor = System.Drawing.Color.Transparent;
            this.labelForImg.ForeColor = System.Drawing.Color.White;
            this.labelForImg.Location = new System.Drawing.Point(308, 40);
            this.labelForImg.Name = "labelForImg";
            this.labelForImg.Size = new System.Drawing.Size(36, 13);
            this.labelForImg.TabIndex = 6;
            this.labelForImg.Text = "Image";
            // 
            // pictureBoxForProductImg
            // 
            this.pictureBoxForProductImg.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxForProductImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxForProductImg.Location = new System.Drawing.Point(293, 69);
            this.pictureBoxForProductImg.Name = "pictureBoxForProductImg";
            this.pictureBoxForProductImg.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxForProductImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxForProductImg.TabIndex = 7;
            this.pictureBoxForProductImg.TabStop = false;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSaveChanges.Location = new System.Drawing.Point(12, 254);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(468, 26);
            this.buttonSaveChanges.TabIndex = 8;
            this.buttonSaveChanges.Text = "Save";
            this.buttonSaveChanges.UseVisualStyleBackColor = false;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonUploadImg
            // 
            this.buttonUploadImg.BackColor = System.Drawing.Color.Transparent;
            this.buttonUploadImg.Location = new System.Drawing.Point(350, 35);
            this.buttonUploadImg.Name = "buttonUploadImg";
            this.buttonUploadImg.Size = new System.Drawing.Size(75, 23);
            this.buttonUploadImg.TabIndex = 9;
            this.buttonUploadImg.Text = "Upload";
            this.buttonUploadImg.UseVisualStyleBackColor = false;
            this.buttonUploadImg.Click += new System.EventHandler(this.buttonUploadImg_Click);
            // 
            // openFileDialogForUpload
            // 
            this.openFileDialogForUpload.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSCS2012.Properties.Resources.coffee_beans_926837_640;
            this.ClientSize = new System.Drawing.Size(492, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonUploadImg);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.pictureBoxForProductImg);
            this.Controls.Add(this.labelForImg);
            this.Controls.Add(this.comboBoxForCategories);
            this.Controls.Add(this.labelForCategory);
            this.Controls.Add(this.labelForPrice);
            this.Controls.Add(this.textBoxForPrice);
            this.Controls.Add(this.textBoxForDescription);
            this.Controls.Add(this.labelForDescription);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForProductImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForDescription;
        private System.Windows.Forms.TextBox textBoxForDescription;
        private System.Windows.Forms.TextBox textBoxForPrice;
        private System.Windows.Forms.Label labelForPrice;
        private System.Windows.Forms.Label labelForCategory;
        private System.Windows.Forms.ComboBox comboBoxForCategories;
        private System.Windows.Forms.Label labelForImg;
        private System.Windows.Forms.PictureBox pictureBoxForProductImg;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button buttonUploadImg;
        private System.Windows.Forms.OpenFileDialog openFileDialogForUpload;
        private System.Windows.Forms.Button button1;
    }
}