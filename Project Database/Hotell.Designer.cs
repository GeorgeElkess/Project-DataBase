namespace Project_Database
{
    partial class Hotel
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
            this.addresstext = new System.Windows.Forms.TextBox();
            this.hotel_id = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nametext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Screen_hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // Screen_hotel
            // 
            this.Screen_hotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Screen_hotel.Location = new System.Drawing.Point(811, 28);
            this.Screen_hotel.Name = "Screen_hotel";
            this.Screen_hotel.RowHeadersWidth = 62;
            this.Screen_hotel.RowTemplate.Height = 33;
            this.Screen_hotel.Size = new System.Drawing.Size(857, 518);
            this.Screen_hotel.TabIndex = 24;
            this.Screen_hotel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Screen_hotel_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 48);
            this.label5.TabIndex = 23;
            this.label5.Text = "Hotel Id";
            // 
            // ratingtext
            // 
            this.ratingtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ratingtext.Location = new System.Drawing.Point(228, 176);
            this.ratingtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ratingtext.Name = "ratingtext";
            this.ratingtext.Size = new System.Drawing.Size(555, 48);
            this.ratingtext.TabIndex = 22;
            this.ratingtext.TextChanged += new System.EventHandler(this.ratingtext_TextChanged);
            this.ratingtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ratingtext_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 332);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 48);
            this.label4.TabIndex = 21;
            this.label4.Text = "Country Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 48);
            this.label3.TabIndex = 20;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 48);
            this.label2.TabIndex = 19;
            this.label2.Text = "Rating";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 48);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Delete.Location = new System.Drawing.Point(581, 416);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(190, 130);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Update.Location = new System.Drawing.Point(368, 416);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(205, 130);
            this.Update.TabIndex = 15;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Search.Location = new System.Drawing.Point(189, 416);
            this.Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(171, 130);
            this.Search.TabIndex = 16;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add.Location = new System.Drawing.Point(13, 416);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(168, 130);
            this.Add.TabIndex = 17;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // addresstext
            // 
            this.addresstext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addresstext.Location = new System.Drawing.Point(228, 259);
            this.addresstext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addresstext.Name = "addresstext";
            this.addresstext.Size = new System.Drawing.Size(558, 48);
            this.addresstext.TabIndex = 11;
            this.addresstext.TextChanged += new System.EventHandler(this.addresstext_TextChanged);
            // 
            // hotel_id
            // 
            this.hotel_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hotel_id.Location = new System.Drawing.Point(228, 40);
            this.hotel_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hotel_id.Name = "hotel_id";
            this.hotel_id.Size = new System.Drawing.Size(558, 48);
            this.hotel_id.TabIndex = 13;
            this.hotel_id.TextChanged += new System.EventHandler(this.hotel_id_TextChanged);
            this.hotel_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hotel_id_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(225, 332);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(558, 56);
            this.comboBox1.TabIndex = 25;
            // 
            // nametext
            // 
            this.nametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nametext.Location = new System.Drawing.Point(228, 100);
            this.nametext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(555, 48);
            this.nametext.TabIndex = 13;
            this.nametext.TextChanged += new System.EventHandler(this.hotel_id_TextChanged);
            this.nametext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hotel_id_KeyPress);
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 568);
            this.Controls.Add(this.comboBox1);
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
            this.Controls.Add(this.addresstext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.hotel_id);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Hotel";
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.Hotell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Screen_hotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Hotell_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
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
        private TextBox addresstext;
        private TextBox hotel_id;
        private ComboBox comboBox1;
        private TextBox nametext;
    }
}