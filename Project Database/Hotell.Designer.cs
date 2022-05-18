namespace Project_Database
{
    partial class Hotell
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
            this.Screen_hotel = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.ratingtext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.country_id_text = new System.Windows.Forms.TextBox();
            this.addresstext = new System.Windows.Forms.TextBox();
            this.nametext = new System.Windows.Forms.TextBox();
            this.hotel_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Screen_hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // Screen_hotel
            // 
            this.Screen_hotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Screen_hotel.Location = new System.Drawing.Point(577, 28);
            this.Screen_hotel.Margin = new System.Windows.Forms.Padding(2);
            this.Screen_hotel.Name = "Screen_hotel";
            this.Screen_hotel.RowHeadersWidth = 62;
            this.Screen_hotel.RowTemplate.Height = 33;
            this.Screen_hotel.Size = new System.Drawing.Size(803, 395);
            this.Screen_hotel.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 32);
            this.label5.TabIndex = 23;
            this.label5.Text = " Hotel Id";
            // 
            // ratingtext
            // 
            this.ratingtext.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ratingtext.Location = new System.Drawing.Point(119, 142);
            this.ratingtext.Name = "ratingtext";
            this.ratingtext.Size = new System.Drawing.Size(439, 34);
            this.ratingtext.TabIndex = 22;
            this.ratingtext.TextChanged += new System.EventHandler(this.ratingtext_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 21;
            this.label4.Text = "Country Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Rating";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(421, 345);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(132, 78);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(272, 345);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(143, 78);
            this.Update.TabIndex = 15;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(147, 345);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(119, 78);
            this.Search.TabIndex = 16;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(26, 345);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(115, 78);
            this.Add.TabIndex = 17;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // country_id_text
            // 
            this.country_id_text.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.country_id_text.Location = new System.Drawing.Point(150, 280);
            this.country_id_text.Name = "country_id_text";
            this.country_id_text.Size = new System.Drawing.Size(408, 34);
            this.country_id_text.TabIndex = 10;
            this.country_id_text.TextChanged += new System.EventHandler(this.country_id_text_TextChanged);
            // 
            // addresstext
            // 
            this.addresstext.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addresstext.Location = new System.Drawing.Point(130, 205);
            this.addresstext.Name = "addresstext";
            this.addresstext.Size = new System.Drawing.Size(424, 34);
            this.addresstext.TabIndex = 11;
            this.addresstext.TextChanged += new System.EventHandler(this.addresstext_TextChanged);
            // 
            // nametext
            // 
            this.nametext.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nametext.Location = new System.Drawing.Point(119, 87);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(438, 34);
            this.nametext.TabIndex = 12;
            this.nametext.TextChanged += new System.EventHandler(this.nametext_TextChanged);
            // 
            // hotel_id
            // 
            this.hotel_id.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hotel_id.Location = new System.Drawing.Point(131, 34);
            this.hotel_id.Name = "hotel_id";
            this.hotel_id.Size = new System.Drawing.Size(426, 34);
            this.hotel_id.TabIndex = 13;
            this.hotel_id.TextChanged += new System.EventHandler(this.hotel_id_TextChanged);
            // 
            // Hotell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 444);
            this.Controls.Add(this.Screen_hotel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ratingtext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.country_id_text);
            this.Controls.Add(this.addresstext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.hotel_id);
            this.Name = "Hotell";
            this.Text = "Hotell";
            ((System.ComponentModel.ISupportInitialize)(this.Screen_hotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView Screen_hotel;
        private Label label5;
        private TextBox ratingtext;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Delete;
        private Button Update;
        private Button Search;
        private Button Add;
        private TextBox country_id_text;
        private TextBox addresstext;
        private TextBox nametext;
        private TextBox hotel_id;
    }
}