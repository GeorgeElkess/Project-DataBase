namespace Project_Database
{
    partial class Customer
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
            this.Customer_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Last_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.ComboBox();
            this.Month = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Passport_ID = new System.Windows.Forms.TextBox();
            this.Screen_hotel = new System.Windows.Forms.DataGridView();
            this.ADD = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Screen_hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // Customer_ID
            // 
            this.Customer_ID.Location = new System.Drawing.Point(28, 95);
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.Size = new System.Drawing.Size(200, 39);
            this.Customer_ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // First_Name
            // 
            this.First_Name.Location = new System.Drawing.Point(28, 217);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(200, 39);
            this.First_Name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name";
            // 
            // Last_Name
            // 
            this.Last_Name.Location = new System.Drawing.Point(262, 217);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(200, 39);
            this.Last_Name.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "SEX";
            // 
            // Sex
            // 
            this.Sex.FormattingEnabled = true;
            this.Sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Sex.Location = new System.Drawing.Point(28, 341);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(175, 76);
            this.Sex.TabIndex = 2;
            this.Sex.SelectedIndexChanged += new System.EventHandler(this.Sex_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date Of Birth";
            // 
            // Day
            // 
            this.Day.FormattingEnabled = true;
            this.Day.Location = new System.Drawing.Point(28, 496);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(58, 40);
            this.Day.TabIndex = 3;
            this.Day.SelectedIndexChanged += new System.EventHandler(this.Day_SelectedIndexChanged);
            // 
            // Month
            // 
            this.Month.FormattingEnabled = true;
            this.Month.Location = new System.Drawing.Point(126, 496);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(77, 40);
            this.Month.TabIndex = 3;
            this.Month.SelectedIndexChanged += new System.EventHandler(this.Month_SelectedIndexChanged);
            // 
            // Year
            // 
            this.Year.FormattingEnabled = true;
            this.Year.Location = new System.Drawing.Point(236, 496);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(102, 40);
            this.Year.TabIndex = 3;
            this.Year.SelectedIndexChanged += new System.EventHandler(this.Year_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 573);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(28, 626);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(200, 39);
            this.Address.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 699);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Passport ID";
            // 
            // Passport_ID
            // 
            this.Passport_ID.Location = new System.Drawing.Point(28, 757);
            this.Passport_ID.Name = "Passport_ID";
            this.Passport_ID.Size = new System.Drawing.Size(200, 39);
            this.Passport_ID.TabIndex = 1;
            // 
            // Screen_hotel
            // 
            this.Screen_hotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Screen_hotel.Location = new System.Drawing.Point(515, 28);
            this.Screen_hotel.Margin = new System.Windows.Forms.Padding(4);
            this.Screen_hotel.Name = "Screen_hotel";
            this.Screen_hotel.RowHeadersWidth = 62;
            this.Screen_hotel.RowTemplate.Height = 33;
            this.Screen_hotel.Size = new System.Drawing.Size(793, 637);
            this.Screen_hotel.TabIndex = 26;
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(544, 721);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(150, 46);
            this.ADD.TabIndex = 27;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(748, 721);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(150, 46);
            this.Search.TabIndex = 27;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(945, 721);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(150, 46);
            this.Update.TabIndex = 27;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(1132, 721);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(150, 46);
            this.Delete.TabIndex = 27;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 829);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.Screen_hotel);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Last_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Passport_ID);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.First_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Customer_ID);
            this.Controls.Add(this.label1);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.Screen_hotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Customer_ID;
        private Label label2;
        private TextBox First_Name;
        private Label label3;
        private TextBox Last_Name;
        private Label label4;
        private CheckedListBox Sex;
        private Label label5;
        private ComboBox Day;
        private ComboBox Month;
        private ComboBox Year;
        private Label label6;
        private TextBox Address;
        private Label label7;
        private TextBox Passport_ID;
        private DataGridView Screen_hotel;
        private Button ADD;
        private Button Search;
        private Button Update;
        private Button Delete;
    }
}