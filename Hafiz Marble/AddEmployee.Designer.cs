namespace Hafiz_Marble
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.button5 = new System.Windows.Forms.Button();
            this.Emp_Age = new System.Windows.Forms.TextBox();
            this.Emp_Contact = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Emp_Salary = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Emp_Post = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Emp_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Emp_ID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dept_Name = new System.Windows.Forms.ComboBox();
            this.hafizDataSet3 = new Hafiz_Marble.HafizDataSet3();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new Hafiz_Marble.HafizDataSet3TableAdapters.DepartmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.button5.TabIndex = 65;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Emp_Age
            // 
            this.Emp_Age.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Age.Location = new System.Drawing.Point(362, 268);
            this.Emp_Age.Name = "Emp_Age";
            this.Emp_Age.Size = new System.Drawing.Size(148, 32);
            this.Emp_Age.TabIndex = 64;
            // 
            // Emp_Contact
            // 
            this.Emp_Contact.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Contact.Location = new System.Drawing.Point(362, 463);
            this.Emp_Contact.Name = "Emp_Contact";
            this.Emp_Contact.Size = new System.Drawing.Size(148, 32);
            this.Emp_Contact.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(352, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 27);
            this.label10.TabIndex = 62;
            this.label10.Text = "Employee Contact ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Emp_Salary
            // 
            this.Emp_Salary.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Salary.Location = new System.Drawing.Point(362, 364);
            this.Emp_Salary.Name = "Emp_Salary";
            this.Emp_Salary.Size = new System.Drawing.Size(148, 32);
            this.Emp_Salary.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(352, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 27);
            this.label9.TabIndex = 60;
            this.label9.Text = "Employee Salary";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(376, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 59;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(371, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 27);
            this.label7.TabIndex = 56;
            this.label7.Text = "Employee Age";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Emp_Post
            // 
            this.Emp_Post.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Post.Location = new System.Drawing.Point(604, 364);
            this.Emp_Post.Name = "Emp_Post";
            this.Emp_Post.Size = new System.Drawing.Size(148, 32);
            this.Emp_Post.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(607, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 27);
            this.label6.TabIndex = 54;
            this.label6.Text = "Employee Post";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(590, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 27);
            this.label3.TabIndex = 52;
            this.label3.Text = "Department Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Emp_Name
            // 
            this.Emp_Name.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Name.Location = new System.Drawing.Point(119, 364);
            this.Emp_Name.Name = "Emp_Name";
            this.Emp_Name.Size = new System.Drawing.Size(148, 32);
            this.Emp_Name.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 27);
            this.label2.TabIndex = 50;
            this.label2.Text = "Employee Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Emp_ID
            // 
            this.Emp_ID.Enabled = false;
            this.Emp_ID.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_ID.Location = new System.Drawing.Point(119, 268);
            this.Emp_ID.Name = "Emp_ID";
            this.Emp_ID.Size = new System.Drawing.Size(148, 32);
            this.Emp_ID.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(352, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 27);
            this.label1.TabIndex = 47;
            this.label1.Text = "Employee ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dept_Name
            // 
            this.Dept_Name.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.departmentBindingSource, "Dept_Name", true));
            this.Dept_Name.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.Dept_Name.FormattingEnabled = true;
            this.Dept_Name.Items.AddRange(new object[] {
            "Accounts",
            "Production",
            "Marketing",
            "Human Resources Management",
            "Sales"});
            this.Dept_Name.Location = new System.Drawing.Point(604, 268);
            this.Dept_Name.Name = "Dept_Name";
            this.Dept_Name.Size = new System.Drawing.Size(148, 35);
            this.Dept_Name.TabIndex = 66;
            // 
            // hafizDataSet3
            // 
            this.hafizDataSet3.DataSetName = "HafizDataSet3";
            this.hafizDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.hafizDataSet3;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 614);
            this.Controls.Add(this.Dept_Name);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Emp_Age);
            this.Controls.Add(this.Emp_Contact);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Emp_Salary);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Emp_Post);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Emp_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Emp_ID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox Emp_Age;
        private System.Windows.Forms.TextBox Emp_Contact;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Emp_Salary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Emp_Post;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Emp_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Emp_ID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Dept_Name;
        private HafizDataSet3 hafizDataSet3;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private HafizDataSet3TableAdapters.DepartmentTableAdapter departmentTableAdapter;
    }
}