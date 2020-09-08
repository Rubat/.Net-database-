namespace Hafiz_Marble
{
    partial class SearchCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCustomer));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hafizDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hafizDataSet = new Hafiz_Marble.HafizDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Hafiz_Marble.HafizDataSetTableAdapters.CustomerTableAdapter();
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hafizDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.hafizDataSet1 = new Hafiz_Marble.HafizDataSet1();
            this.hafizDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter1 = new Hafiz_Marble.HafizDataSet1TableAdapters.CustomerTableAdapter();
            this.cusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusMembershipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusCommentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 626);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Cus_ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cusIDDataGridViewTextBoxColumn,
            this.cusNameDataGridViewTextBoxColumn,
            this.cusAddressDataGridViewTextBoxColumn,
            this.cusEmailDataGridViewTextBoxColumn,
            this.cusPhoneDataGridViewTextBoxColumn,
            this.cusMembershipDataGridViewTextBoxColumn,
            this.cusCommentsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(85, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(819, 361);
            this.dataGridView1.TabIndex = 2;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.hafizDataSetBindingSource;
            // 
            // hafizDataSetBindingSource
            // 
            this.hafizDataSetBindingSource.DataSource = this.hafizDataSet;
            this.hafizDataSetBindingSource.Position = 0;
            // 
            // hafizDataSet
            // 
            this.hafizDataSet.DataSetName = "HafizDataSet";
            this.hafizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(408, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            this.button5.TabIndex = 12;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Show Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.hafizDataSetBindingSource;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataMember = "Customer";
            this.customerBindingSource2.DataSource = this.hafizDataSetBindingSource;
            // 
            // hafizDataSetBindingSource1
            // 
            this.hafizDataSetBindingSource1.DataSource = this.hafizDataSet;
            this.hafizDataSetBindingSource1.Position = 0;
            // 
            // customerBindingSource3
            // 
            this.customerBindingSource3.DataMember = "Customer";
            this.customerBindingSource3.DataSource = this.hafizDataSet;
            // 
            // customerBindingSource4
            // 
            this.customerBindingSource4.DataMember = "Customer";
            this.customerBindingSource4.DataSource = this.hafizDataSetBindingSource1;
            // 
            // hafizDataSet1
            // 
            this.hafizDataSet1.DataSetName = "HafizDataSet1";
            this.hafizDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hafizDataSet1BindingSource
            // 
            this.hafizDataSet1BindingSource.DataSource = this.hafizDataSet1;
            this.hafizDataSet1BindingSource.Position = 0;
            // 
            // customerBindingSource5
            // 
            this.customerBindingSource5.DataMember = "Customer";
            this.customerBindingSource5.DataSource = this.hafizDataSet1BindingSource;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // cusIDDataGridViewTextBoxColumn
            // 
            this.cusIDDataGridViewTextBoxColumn.DataPropertyName = "Cus_ID";
            this.cusIDDataGridViewTextBoxColumn.HeaderText = "Cus_ID";
            this.cusIDDataGridViewTextBoxColumn.Name = "cusIDDataGridViewTextBoxColumn";
            this.cusIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cusNameDataGridViewTextBoxColumn
            // 
            this.cusNameDataGridViewTextBoxColumn.DataPropertyName = "Cus_Name";
            this.cusNameDataGridViewTextBoxColumn.HeaderText = "Cus_Name";
            this.cusNameDataGridViewTextBoxColumn.Name = "cusNameDataGridViewTextBoxColumn";
            this.cusNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cusAddressDataGridViewTextBoxColumn
            // 
            this.cusAddressDataGridViewTextBoxColumn.DataPropertyName = "Cus_Address";
            this.cusAddressDataGridViewTextBoxColumn.HeaderText = "Cus_Address";
            this.cusAddressDataGridViewTextBoxColumn.Name = "cusAddressDataGridViewTextBoxColumn";
            this.cusAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cusEmailDataGridViewTextBoxColumn
            // 
            this.cusEmailDataGridViewTextBoxColumn.DataPropertyName = "Cus_Email";
            this.cusEmailDataGridViewTextBoxColumn.HeaderText = "Cus_Email";
            this.cusEmailDataGridViewTextBoxColumn.Name = "cusEmailDataGridViewTextBoxColumn";
            this.cusEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cusPhoneDataGridViewTextBoxColumn
            // 
            this.cusPhoneDataGridViewTextBoxColumn.DataPropertyName = "Cus_Phone";
            this.cusPhoneDataGridViewTextBoxColumn.HeaderText = "Cus_Phone";
            this.cusPhoneDataGridViewTextBoxColumn.Name = "cusPhoneDataGridViewTextBoxColumn";
            this.cusPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cusMembershipDataGridViewTextBoxColumn
            // 
            this.cusMembershipDataGridViewTextBoxColumn.DataPropertyName = "Cus_Membership";
            this.cusMembershipDataGridViewTextBoxColumn.HeaderText = "Cus_Membership";
            this.cusMembershipDataGridViewTextBoxColumn.Name = "cusMembershipDataGridViewTextBoxColumn";
            this.cusMembershipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cusCommentsDataGridViewTextBoxColumn
            // 
            this.cusCommentsDataGridViewTextBoxColumn.DataPropertyName = "Cus_Comments";
            this.cusCommentsDataGridViewTextBoxColumn.HeaderText = "Cus_Comments";
            this.cusCommentsDataGridViewTextBoxColumn.Name = "cusCommentsDataGridViewTextBoxColumn";
            this.cusCommentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusCommentsDataGridViewTextBoxColumn.Width = 200;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(685, 625);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 27);
            this.textBox1.TabIndex = 14;
            // 
            // SearchCustomer
            // 
            this.AccessibleName = "SearchCustomer";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 691);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchCustomer";
            this.Load += new System.EventHandler(this.SearchCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource hafizDataSetBindingSource;
        private HafizDataSet hafizDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private HafizDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private System.Windows.Forms.BindingSource customerBindingSource3;
        private System.Windows.Forms.BindingSource hafizDataSetBindingSource1;
        private System.Windows.Forms.BindingSource hafizDataSet1BindingSource;
        private HafizDataSet1 hafizDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource4;
        private System.Windows.Forms.BindingSource customerBindingSource5;
        private HafizDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusMembershipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusCommentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
    }
}