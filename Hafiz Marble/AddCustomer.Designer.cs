namespace Hafiz_Marble
{
    partial class AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cus_ID = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hafizDataSet = new Hafiz_Marble.HafizDataSet();
            this.Cus_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cus_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cus_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cus_Phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Cus_Comments = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.customerTableAdapter = new Hafiz_Marble.HafizDataSetTableAdapters.CustomerTableAdapter();
            this.Cus_Membership = new System.Windows.Forms.ComboBox();
            this.hafizDataSet1 = new Hafiz_Marble.HafizDataSet1();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter1 = new Hafiz_Marble.HafizDataSet1TableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Cus_ID
            // 
            this.Cus_ID.Enabled = false;
            this.Cus_ID.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_ID.Location = new System.Drawing.Point(110, 223);
            this.Cus_ID.Name = "Cus_ID";
            this.Cus_ID.Size = new System.Drawing.Size(148, 32);
            this.Cus_ID.TabIndex = 2;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.hafizDataSet;
            // 
            // hafizDataSet
            // 
            this.hafizDataSet.DataSetName = "HafizDataSet";
            this.hafizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Cus_Name
            // 
            this.Cus_Name.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_Name.Location = new System.Drawing.Point(110, 319);
            this.Cus_Name.Name = "Cus_Name";
            this.Cus_Name.Size = new System.Drawing.Size(148, 32);
            this.Cus_Name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Name";
            // 
            // Cus_Address
            // 
            this.Cus_Address.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_Address.Location = new System.Drawing.Point(110, 423);
            this.Cus_Address.Name = "Cus_Address";
            this.Cus_Address.Size = new System.Drawing.Size(148, 32);
            this.Cus_Address.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // Cus_Email
            // 
            this.Cus_Email.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_Email.Location = new System.Drawing.Point(360, 223);
            this.Cus_Email.Name = "Cus_Email";
            this.Cus_Email.Size = new System.Drawing.Size(148, 32);
            this.Cus_Email.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Cus_Phone
            // 
            this.Cus_Phone.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_Phone.Location = new System.Drawing.Point(360, 319);
            this.Cus_Phone.Name = "Cus_Phone";
            this.Cus_Phone.Size = new System.Drawing.Size(148, 32);
            this.Cus_Phone.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone #";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(350, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "Membership Level";
            // 
            // Cus_Comments
            // 
            this.Cus_Comments.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_Comments.Location = new System.Drawing.Point(599, 223);
            this.Cus_Comments.Multiline = true;
            this.Cus_Comments.Name = "Cus_Comments";
            this.Cus_Comments.Size = new System.Drawing.Size(148, 232);
            this.Cus_Comments.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(621, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "Comments";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(372, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.button5.TabIndex = 19;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // Cus_Membership
            // 
            this.Cus_Membership.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_Membership.FormattingEnabled = true;
            this.Cus_Membership.Items.AddRange(new object[] {
            "Bronze",
            "Silver",
            "Gold",
            "Platinum",
            "Diamond",
            ""});
            this.Cus_Membership.Location = new System.Drawing.Point(364, 423);
            this.Cus_Membership.Name = "Cus_Membership";
            this.Cus_Membership.Size = new System.Drawing.Size(148, 35);
            this.Cus_Membership.TabIndex = 17;
            this.Cus_Membership.SelectedIndexChanged += new System.EventHandler(this.Cus_Membership_SelectedIndexChanged);
            // 
            // hafizDataSet1
            // 
            this.hafizDataSet1.DataSetName = "HafizDataSet1";
            this.hafizDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.hafizDataSet1;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 567);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cus_Membership);
            this.Controls.Add(this.Cus_Comments);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Cus_Phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cus_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cus_Address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cus_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cus_ID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Cus_ID;
        private System.Windows.Forms.TextBox Cus_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cus_Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cus_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Cus_Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Cus_Comments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private HafizDataSet hafizDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private HafizDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.ComboBox Cus_Membership;
        private HafizDataSet1 hafizDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private HafizDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter1;
    }
}