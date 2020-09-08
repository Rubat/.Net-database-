namespace Hafiz_Marble
{
    partial class RemoveProduct
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveProduct));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Search_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Prod_Price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Prod_Category = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Prod_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Prod_Design = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Prod_Diameter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Prod_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Prod_Weight = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.hafizDataSheetProduct = new Hafiz_Marble.HafizDataSheetProduct();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Hafiz_Marble.HafizDataSheetProductTableAdapters.ProductTableAdapter();
            this.prodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDesignDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDiameterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSheetProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(177, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // Search_ID
            // 
            this.Search_ID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_ID.Location = new System.Drawing.Point(688, 203);
            this.Search_ID.Name = "Search_ID";
            this.Search_ID.Size = new System.Drawing.Size(291, 26);
            this.Search_ID.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(551, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 27);
            this.label8.TabIndex = 35;
            this.label8.Text = "Search Name";
            // 
            // button1
            // 
            this.button1.AccessibleName = "Removebtn";
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(177, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 38);
            this.button1.TabIndex = 34;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Prod_Price
            // 
            this.Prod_Price.Enabled = false;
            this.Prod_Price.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prod_Price.Location = new System.Drawing.Point(263, 532);
            this.Prod_Price.Name = "Prod_Price";
            this.Prod_Price.Size = new System.Drawing.Size(225, 26);
            this.Prod_Price.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Price";
            // 
            // Prod_Category
            // 
            this.Prod_Category.Enabled = false;
            this.Prod_Category.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prod_Category.Location = new System.Drawing.Point(263, 488);
            this.Prod_Category.Name = "Prod_Category";
            this.Prod_Category.Size = new System.Drawing.Size(225, 26);
            this.Prod_Category.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Category";
            // 
            // Prod_Name
            // 
            this.Prod_Name.Enabled = false;
            this.Prod_Name.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prod_Name.Location = new System.Drawing.Point(263, 308);
            this.Prod_Name.Name = "Prod_Name";
            this.Prod_Name.Size = new System.Drawing.Size(225, 26);
            this.Prod_Name.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Product Name";
            // 
            // Prod_Design
            // 
            this.Prod_Design.Enabled = false;
            this.Prod_Design.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prod_Design.Location = new System.Drawing.Point(263, 349);
            this.Prod_Design.Name = "Prod_Design";
            this.Prod_Design.Size = new System.Drawing.Size(225, 26);
            this.Prod_Design.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Diameter";
            // 
            // Prod_Diameter
            // 
            this.Prod_Diameter.Enabled = false;
            this.Prod_Diameter.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prod_Diameter.Location = new System.Drawing.Point(263, 395);
            this.Prod_Diameter.Name = "Prod_Diameter";
            this.Prod_Diameter.Size = new System.Drawing.Size(225, 26);
            this.Prod_Diameter.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Design Type";
            // 
            // Prod_ID
            // 
            this.Prod_ID.Enabled = false;
            this.Prod_ID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prod_ID.Location = new System.Drawing.Point(263, 263);
            this.Prod_ID.Name = "Prod_ID";
            this.Prod_ID.Size = new System.Drawing.Size(225, 26);
            this.Prod_ID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Product ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodIDDataGridViewTextBoxColumn,
            this.prodNameDataGridViewTextBoxColumn,
            this.prodDesignDataGridViewTextBoxColumn,
            this.prodDiameterDataGridViewTextBoxColumn,
            this.prodWeightDataGridViewTextBoxColumn,
            this.prodCategoryDataGridViewTextBoxColumn,
            this.prodPriceDataGridViewTextBoxColumn,
            this.prodCommentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(556, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 364);
            this.dataGridView1.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 44);
            this.button5.TabIndex = 38;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 22);
            this.label7.TabIndex = 40;
            this.label7.Text = "Weight";
            // 
            // Prod_Weight
            // 
            this.Prod_Weight.Enabled = false;
            this.Prod_Weight.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prod_Weight.Location = new System.Drawing.Point(263, 441);
            this.Prod_Weight.Name = "Prod_Weight";
            this.Prod_Weight.Size = new System.Drawing.Size(225, 26);
            this.Prod_Weight.TabIndex = 39;
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.LightGreen;
            this.Search_button.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.ForeColor = System.Drawing.Color.White;
            this.Search_button.Location = new System.Drawing.Point(985, 202);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(78, 33);
            this.Search_button.TabIndex = 73;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // hafizDataSheetProduct
            // 
            this.hafizDataSheetProduct.DataSetName = "HafizDataSheetProduct";
            this.hafizDataSheetProduct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.hafizDataSheetProduct;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // prodIDDataGridViewTextBoxColumn
            // 
            this.prodIDDataGridViewTextBoxColumn.DataPropertyName = "Prod_ID";
            this.prodIDDataGridViewTextBoxColumn.HeaderText = "Prod_ID";
            this.prodIDDataGridViewTextBoxColumn.Name = "prodIDDataGridViewTextBoxColumn";
            this.prodIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "Prod_Name";
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "Prod_Name";
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            // 
            // prodDesignDataGridViewTextBoxColumn
            // 
            this.prodDesignDataGridViewTextBoxColumn.DataPropertyName = "Prod_Design";
            this.prodDesignDataGridViewTextBoxColumn.HeaderText = "Prod_Design";
            this.prodDesignDataGridViewTextBoxColumn.Name = "prodDesignDataGridViewTextBoxColumn";
            // 
            // prodDiameterDataGridViewTextBoxColumn
            // 
            this.prodDiameterDataGridViewTextBoxColumn.DataPropertyName = "Prod_Diameter";
            this.prodDiameterDataGridViewTextBoxColumn.HeaderText = "Prod_Diameter";
            this.prodDiameterDataGridViewTextBoxColumn.Name = "prodDiameterDataGridViewTextBoxColumn";
            // 
            // prodWeightDataGridViewTextBoxColumn
            // 
            this.prodWeightDataGridViewTextBoxColumn.DataPropertyName = "Prod_Weight";
            this.prodWeightDataGridViewTextBoxColumn.HeaderText = "Prod_Weight";
            this.prodWeightDataGridViewTextBoxColumn.Name = "prodWeightDataGridViewTextBoxColumn";
            // 
            // prodCategoryDataGridViewTextBoxColumn
            // 
            this.prodCategoryDataGridViewTextBoxColumn.DataPropertyName = "Prod_Category";
            this.prodCategoryDataGridViewTextBoxColumn.HeaderText = "Prod_Category";
            this.prodCategoryDataGridViewTextBoxColumn.Name = "prodCategoryDataGridViewTextBoxColumn";
            // 
            // prodPriceDataGridViewTextBoxColumn
            // 
            this.prodPriceDataGridViewTextBoxColumn.DataPropertyName = "Prod_Price";
            this.prodPriceDataGridViewTextBoxColumn.HeaderText = "Prod_Price";
            this.prodPriceDataGridViewTextBoxColumn.Name = "prodPriceDataGridViewTextBoxColumn";
            // 
            // prodCommentDataGridViewTextBoxColumn
            // 
            this.prodCommentDataGridViewTextBoxColumn.DataPropertyName = "Prod_Comment";
            this.prodCommentDataGridViewTextBoxColumn.HeaderText = "Prod_Comment";
            this.prodCommentDataGridViewTextBoxColumn.Name = "prodCommentDataGridViewTextBoxColumn";
            // 
            // RemoveProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 670);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Prod_Weight);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Search_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Prod_Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Prod_Category);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Prod_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Prod_Design);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Prod_Diameter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Prod_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveProduct";
            this.Load += new System.EventHandler(this.RemoveProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSheetProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Search_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Prod_Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Prod_Category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Prod_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Prod_Design;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Prod_Diameter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Prod_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Prod_Weight;
        private System.Windows.Forms.Button Search_button;
        private HafizDataSheetProduct hafizDataSheetProduct;
        private System.Windows.Forms.BindingSource productBindingSource;
        private HafizDataSheetProductTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDesignDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDiameterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCommentDataGridViewTextBoxColumn;
    }
}