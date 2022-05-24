namespace Project_Database
{
    partial class Employee
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
            this.label1 = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Last_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.ComboBox();
            this.Month = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.Job_Title = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Working_Hours = new System.Windows.Forms.TextBox();
            this.Screen_hotel = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Employee_ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Screen_hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // First_Name
            // 
            this.First_Name.Location = new System.Drawing.Point(38, 178);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(200, 39);
            this.First_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 0;
            // 
            // Last_Name
            // 
            this.Last_Name.Location = new System.Drawing.Point(252, 178);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(200, 39);
            this.Last_Name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name";
            // 
            // Day
            // 
            this.Day.FormattingEnabled = true;
            this.Day.Location = new System.Drawing.Point(38, 302);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(79, 40);
            this.Day.TabIndex = 2;
            this.Day.SelectedIndexChanged += new System.EventHandler(this.Day_SelectedIndexChanged);
            // 
            // Month
            // 
            this.Month.FormattingEnabled = true;
            this.Month.Location = new System.Drawing.Point(144, 302);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(86, 40);
            this.Month.TabIndex = 2;
            this.Month.SelectedIndexChanged += new System.EventHandler(this.Month_SelectedIndexChanged);
            // 
            // Year
            // 
            this.Year.FormattingEnabled = true;
            this.Year.Location = new System.Drawing.Point(252, 302);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(112, 40);
            this.Year.TabIndex = 2;
            this.Year.SelectedIndexChanged += new System.EventHandler(this.Year_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Salary";
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(266, 529);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(200, 39);
            this.Salary.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(38, 424);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(200, 39);
            this.Address.TabIndex = 3;
            // 
            // Job_Title
            // 
            this.Job_Title.Location = new System.Drawing.Point(38, 529);
            this.Job_Title.Name = "Job_Title";
            this.Job_Title.Size = new System.Drawing.Size(200, 39);
            this.Job_Title.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Job Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 32);
            this.label8.TabIndex = 5;
            this.label8.Text = "Working Hours";
            // 
            // Working_Hours
            // 
            this.Working_Hours.Location = new System.Drawing.Point(38, 649);
            this.Working_Hours.Name = "Working_Hours";
            this.Working_Hours.Size = new System.Drawing.Size(200, 39);
            this.Working_Hours.TabIndex = 3;
            // 
            // Screen_hotel
            // 
            this.Screen_hotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Screen_hotel.Location = new System.Drawing.Point(518, 39);
            this.Screen_hotel.Margin = new System.Windows.Forms.Padding(4);
            this.Screen_hotel.Name = "Screen_hotel";
            this.Screen_hotel.RowHeadersWidth = 62;
            this.Screen_hotel.RowTemplate.Height = 33;
            this.Screen_hotel.Size = new System.Drawing.Size(829, 577);
            this.Screen_hotel.TabIndex = 25;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(582, 664);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(150, 46);
            this.Add.TabIndex = 26;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(785, 664);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(150, 46);
            this.Search.TabIndex = 27;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(989, 664);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(150, 46);
            this.Update.TabIndex = 28;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(1188, 664);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(150, 46);
            this.Delete.TabIndex = 28;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Employee_ID
            // 
            this.Employee_ID.Location = new System.Drawing.Point(38, 67);
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.Size = new System.Drawing.Size(200, 39);
            this.Employee_ID.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 32);
            this.label9.TabIndex = 29;
            this.label9.Text = "Employee ID";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 752);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Screen_hotel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Job_Title);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Working_Hours);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Last_Name);
            this.Controls.Add(this.Employee_ID);
            this.Controls.Add(this.First_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Employee";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.Screen_hotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox First_Name;
        private Label label2;
        private TextBox Last_Name;
        private Label label3;
        private ComboBox Day;
        private ComboBox Month;
        private ComboBox Year;
        private Label label4;
        private Label label5;
        private TextBox Salary;
        private Label label6;
        private TextBox Address;
        private TextBox Job_Title;
        private Label label7;
        private Label label8;
        private TextBox Working_Hours;
        private DataGridView Screen_hotel;
        private Button Add;
        private Button Search;
        private Button Update;
        private Button Delete;
        private TextBox Employee_ID;
        private Label label9;
    }
}