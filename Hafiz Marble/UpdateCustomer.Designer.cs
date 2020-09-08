namespace Hafiz_Marble
{
    partial class UpdateCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCustomer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Cus_Address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cus_Phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cus_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cus_Membership = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cus_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cus_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.hafizDataSet1 = new Hafiz_Marble.HafizDataSet1();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Hafiz_Marble.HafizDataSet1TableAdapters.CustomerTableAdapter();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Cus_Comments = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusMembershipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusCommentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search_ID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(536, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 27);
            this.label8.TabIndex = 35;
            this.label8.Text = "Search Cus_ID";
            // 
            // button1
            // 
            this.button1.AccessibleName = "Removebtn";
            this.button1.BackColor = System.Drawing.Color.BlueViolet;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(175, 792);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 38);
            this.button1.TabIndex = 34;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cus_Address
            // 
            this.Cus_Address.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_Address.Location = new System.Drawing.Point(259, 366);
            this.Cus_Address.Name = "Cus_Address";
            this.Cus_Address.Size = new System.Drawing.Size(225, 26);
            this.Cus_Address.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Address";
            // 
            // Cus_Phone
            // 
            this.Cus_Phone.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_Phone.Location = new System.Drawing.Point(259, 481);
            this.Cus_Phone.Name = "Cus_Phone";
            this.Cus_Phone.Size = new System.Drawing.Size(225, 26);
            this.Cus_Phone.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Phone No.";
            // 
            // Cus_Name
            // 
            this.Cus_Name.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_Name.Location = new System.Drawing.Point(259, 308);
            this.Cus_Name.Name = "Cus_Name";
            this.Cus_Name.Size = new System.Drawing.Size(225, 26);
            this.Cus_Name.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Customer Name";
            // 
            // Cus_Membership
            // 
            this.Cus_Membership.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_Membership.Location = new System.Drawing.Point(259, 544);
            this.Cus_Membership.Name = "Cus_Membership";
            this.Cus_Membership.Size = new System.Drawing.Size(225, 26);
            this.Cus_Membership.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Membership Level";
            // 
            // Cus_Email
            // 
            this.Cus_Email.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_Email.Location = new System.Drawing.Point(259, 423);
            this.Cus_Email.Name = "Cus_Email";
            this.Cus_Email.Size = new System.Drawing.Size(225, 26);
            this.Cus_Email.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Email";
            // 
            // Cus_ID
            // 
            this.Cus_ID.Enabled = false;
            this.Cus_ID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_ID.Location = new System.Drawing.Point(259, 249);
            this.Cus_ID.Name = "Cus_ID";
            this.Cus_ID.Size = new System.Drawing.Size(225, 26);
            this.Cus_ID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Customer ID";
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
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(537, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(653, 468);
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
            this.button5.Location = new System.Drawing.Point(12, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 44);
            this.button5.TabIndex = 38;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // hafizDataSet1
            // 
            this.hafizDataSet1.DataSetName = "HafizDataSet1";
            this.hafizDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.hafizDataSet1;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.hafizDataSet1;
            // 
            // Cus_Comments
            // 
            this.Cus_Comments.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_Comments.Location = new System.Drawing.Point(259, 608);
            this.Cus_Comments.Multiline = true;
            this.Cus_Comments.Name = "Cus_Comments";
            this.Cus_Comments.Size = new System.Drawing.Size(225, 154);
            this.Cus_Comments.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 608);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 22);
            this.label7.TabIndex = 40;
            this.label7.Text = "Comments";
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
            // Search_ID
            // 
            this.Search_ID.AcceptsReturn = true;
            this.Search_ID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_ID.Location = new System.Drawing.Point(685, 213);
            this.Search_ID.Multiline = true;
            this.Search_ID.Name = "Search_ID";
            this.Search_ID.Size = new System.Drawing.Size(225, 33);
            this.Search_ID.TabIndex = 42;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(925, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 33);
            this.button2.TabIndex = 43;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 842);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Search_ID);
            this.Controls.Add(this.Cus_Comments);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cus_Address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cus_Phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cus_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cus_Membership);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cus_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cus_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCustomer";
            this.Load += new System.EventHandler(this.UpdateCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Cus_Address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Cus_Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Cus_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Cus_Membership;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cus_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cus_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private HafizDataSet1 hafizDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private HafizDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.TextBox Cus_Comments;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusMembershipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusCommentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox Search_ID;
        private System.Windows.Forms.Button button2;
    }
}