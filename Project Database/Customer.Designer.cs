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
            this.label6 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Passport_ID = new System.Windows.Forms.TextBox();
            this.Screen_hotel = new System.Windows.Forms.DataGridView();
            this.ADD = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Date_Of_Birth = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Screen_hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // Customer_ID
            // 
            this.Customer_ID.Location = new System.Drawing.Point(22, 74);
            this.Customer_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.Size = new System.Drawing.Size(155, 31);
            this.Customer_ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // First_Name
            // 
            this.First_Name.Location = new System.Drawing.Point(22, 170);
            this.First_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(155, 31);
            this.First_Name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name";
            // 
            // Last_Name
            // 
            this.Last_Name.Location = new System.Drawing.Point(202, 170);
            this.Last_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(155, 31);
            this.Last_Name.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "SEX";
            // 
            // Sex
            // 
            this.Sex.FormattingEnabled = true;
            this.Sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Sex.Location = new System.Drawing.Point(22, 266);
            this.Sex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(136, 60);
            this.Sex.TabIndex = 2;
            this.Sex.SelectedIndexChanged += new System.EventHandler(this.Sex_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 345);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 448);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(22, 489);
            this.Address.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(155, 31);
            this.Address.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 546);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Passport ID";
            // 
            // Passport_ID
            // 
            this.Passport_ID.Location = new System.Drawing.Point(22, 591);
            this.Passport_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Passport_ID.Name = "Passport_ID";
            this.Passport_ID.Size = new System.Drawing.Size(155, 31);
            this.Passport_ID.TabIndex = 1;
            // 
            // Screen_hotel
            // 
            this.Screen_hotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Screen_hotel.Location = new System.Drawing.Point(396, 22);
            this.Screen_hotel.Name = "Screen_hotel";
            this.Screen_hotel.RowHeadersWidth = 62;
            this.Screen_hotel.RowTemplate.Height = 33;
            this.Screen_hotel.Size = new System.Drawing.Size(610, 498);
            this.Screen_hotel.TabIndex = 26;
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(418, 563);
            this.ADD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(115, 36);
            this.ADD.TabIndex = 27;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(575, 563);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(115, 36);
            this.Search.TabIndex = 27;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(727, 563);
            this.Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(115, 36);
            this.Update.TabIndex = 27;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(871, 563);
            this.Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(115, 36);
            this.Delete.TabIndex = 27;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Date_Of_Birth
            // 
            this.Date_Of_Birth.Location = new System.Drawing.Point(22, 392);
            this.Date_Of_Birth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Date_Of_Birth.Name = "Date_Of_Birth";
            this.Date_Of_Birth.Size = new System.Drawing.Size(309, 31);
            this.Date_Of_Birth.TabIndex = 31;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 648);
            this.Controls.Add(this.Date_Of_Birth);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.Screen_hotel);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
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
        private Label label6;
        private TextBox Address;
        private Label label7;
        private TextBox Passport_ID;
        private DataGridView Screen_hotel;
        private Button ADD;
        private Button Search;
        private Button Update;
        private Button Delete;
        private DateTimePicker Date_Of_Birth;
    }
}