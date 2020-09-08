namespace Hafiz_Marble
{
    partial class UpdateEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateEmployee));
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Emp_Salary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Emp_Age = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Search_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Emp_Post = new System.Windows.Forms.TextBox();
            this.Dept_Name = new System.Windows.Forms.TextBox();
            this.Emp_Name = new System.Windows.Forms.TextBox();
            this.Emp_Contact = new System.Windows.Forms.TextBox();
            this.Emp_ID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empPostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hafizDataSet4 = new Hafiz_Marble.HafizDataSet4();
            this.button1 = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new Hafiz_Marble.HafizDataSet4TableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSet4)).BeginInit();
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
            this.button5.TabIndex = 20;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(164, 19);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(188, 192);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 92;
            this.pictureBox5.TabStop = false;
            // 
            // Emp_Salary
            // 
            this.Emp_Salary.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Salary.Location = new System.Drawing.Point(248, 343);
            this.Emp_Salary.Name = "Emp_Salary";
            this.Emp_Salary.Size = new System.Drawing.Size(225, 26);
            this.Emp_Salary.TabIndex = 91;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(58, 457);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 27);
            this.label10.TabIndex = 90;
            this.label10.Text = "Employee Contact ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 27);
            this.label9.TabIndex = 89;
            this.label9.Text = "Employee Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 573);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 27);
            this.label6.TabIndex = 88;
            this.label6.Text = "Employee Post";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 27);
            this.label2.TabIndex = 87;
            this.label2.Text = "Employee Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 27);
            this.label7.TabIndex = 86;
            this.label7.Text = "Employee Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 27);
            this.label3.TabIndex = 85;
            this.label3.Text = "Department Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 27);
            this.label1.TabIndex = 84;
            this.label1.Text = "Employee ID";
            // 
            // Emp_Age
            // 
            this.Emp_Age.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Age.Location = new System.Drawing.Point(248, 399);
            this.Emp_Age.Name = "Emp_Age";
            this.Emp_Age.Size = new System.Drawing.Size(225, 26);
            this.Emp_Age.TabIndex = 83;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(867, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 33);
            this.button2.TabIndex = 82;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Search_ID
            // 
            this.Search_ID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_ID.Location = new System.Drawing.Point(674, 216);
            this.Search_ID.Name = "Search_ID";
            this.Search_ID.Size = new System.Drawing.Size(187, 26);
            this.Search_ID.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(525, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 27);
            this.label8.TabIndex = 80;
            this.label8.Text = "Search Emp_ID";
            // 
            // Emp_Post
            // 
            this.Emp_Post.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Post.Location = new System.Drawing.Point(248, 573);
            this.Emp_Post.Name = "Emp_Post";
            this.Emp_Post.Size = new System.Drawing.Size(225, 26);
            this.Emp_Post.TabIndex = 79;
            // 
            // Dept_Name
            // 
            this.Dept_Name.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dept_Name.Location = new System.Drawing.Point(248, 516);
            this.Dept_Name.Name = "Dept_Name";
            this.Dept_Name.Size = new System.Drawing.Size(225, 26);
            this.Dept_Name.TabIndex = 78;
            // 
            // Emp_Name
            // 
            this.Emp_Name.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Name.Location = new System.Drawing.Point(248, 294);
            this.Emp_Name.Name = "Emp_Name";
            this.Emp_Name.Size = new System.Drawing.Size(225, 26);
            this.Emp_Name.TabIndex = 77;
            // 
            // Emp_Contact
            // 
            this.Emp_Contact.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Contact.Location = new System.Drawing.Point(248, 458);
            this.Emp_Contact.Name = "Emp_Contact";
            this.Emp_Contact.Size = new System.Drawing.Size(225, 26);
            this.Emp_Contact.TabIndex = 76;
            // 
            // Emp_ID
            // 
            this.Emp_ID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_ID.Location = new System.Drawing.Point(248, 245);
            this.Emp_ID.Name = "Emp_ID";
            this.Emp_ID.Size = new System.Drawing.Size(225, 26);
            this.Emp_ID.TabIndex = 75;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIDDataGridViewTextBoxColumn,
            this.empNameDataGridViewTextBoxColumn,
            this.empAgeDataGridViewTextBoxColumn,
            this.empSalaryDataGridViewTextBoxColumn,
            this.empContactDataGridViewTextBoxColumn,
            this.empPostDataGridViewTextBoxColumn,
            this.deptNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(526, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 364);
            this.dataGridView1.TabIndex = 74;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empNameDataGridViewTextBoxColumn
            // 
            this.empNameDataGridViewTextBoxColumn.DataPropertyName = "Emp_Name";
            this.empNameDataGridViewTextBoxColumn.HeaderText = "Emp_Name";
            this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
            // 
            // empAgeDataGridViewTextBoxColumn
            // 
            this.empAgeDataGridViewTextBoxColumn.DataPropertyName = "Emp_Age";
            this.empAgeDataGridViewTextBoxColumn.HeaderText = "Emp_Age";
            this.empAgeDataGridViewTextBoxColumn.Name = "empAgeDataGridViewTextBoxColumn";
            // 
            // empSalaryDataGridViewTextBoxColumn
            // 
            this.empSalaryDataGridViewTextBoxColumn.DataPropertyName = "Emp_Salary";
            this.empSalaryDataGridViewTextBoxColumn.HeaderText = "Emp_Salary";
            this.empSalaryDataGridViewTextBoxColumn.Name = "empSalaryDataGridViewTextBoxColumn";
            // 
            // empContactDataGridViewTextBoxColumn
            // 
            this.empContactDataGridViewTextBoxColumn.DataPropertyName = "Emp_Contact";
            this.empContactDataGridViewTextBoxColumn.HeaderText = "Emp_Contact";
            this.empContactDataGridViewTextBoxColumn.Name = "empContactDataGridViewTextBoxColumn";
            // 
            // empPostDataGridViewTextBoxColumn
            // 
            this.empPostDataGridViewTextBoxColumn.DataPropertyName = "Emp_Post";
            this.empPostDataGridViewTextBoxColumn.HeaderText = "Emp_Post";
            this.empPostDataGridViewTextBoxColumn.Name = "empPostDataGridViewTextBoxColumn";
            // 
            // deptNameDataGridViewTextBoxColumn
            // 
            this.deptNameDataGridViewTextBoxColumn.DataPropertyName = "Dept_Name";
            this.deptNameDataGridViewTextBoxColumn.HeaderText = "Dept_Name";
            this.deptNameDataGridViewTextBoxColumn.Name = "deptNameDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.hafizDataSet4;
            // 
            // hafizDataSet4
            // 
            this.hafizDataSet4.DataSetName = "HafizDataSet4";
            this.hafizDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.AccessibleName = "Removebtn";
            this.button1.BackColor = System.Drawing.Color.BlueViolet;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(164, 660);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 38);
            this.button1.TabIndex = 93;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 710);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Emp_Salary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Emp_Age);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Search_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Emp_Post);
            this.Controls.Add(this.Dept_Name);
            this.Controls.Add(this.Emp_Name);
            this.Controls.Add(this.Emp_Contact);
            this.Controls.Add(this.Emp_ID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateEmployee";
            this.Load += new System.EventHandler(this.UpdateEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafizDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox Emp_Salary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Emp_Age;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Search_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Emp_Post;
        private System.Windows.Forms.TextBox Dept_Name;
        private System.Windows.Forms.TextBox Emp_Name;
        private System.Windows.Forms.TextBox Emp_Contact;
        private System.Windows.Forms.TextBox Emp_ID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private HafizDataSet4 hafizDataSet4;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private HafizDataSet4TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptNameDataGridViewTextBoxColumn;
    }
}