namespace Project_Database
{
    partial class Categorie
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Screen_hotel = new System.Windows.Forms.DataGridView();
            this.ratingtext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.costparday = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.costpardaytext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.categorie_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nametext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Screen_hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 237);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(423, 23);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Screen_hotel
            // 
            this.Screen_hotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Screen_hotel.Location = new System.Drawing.Point(588, 11);
            this.Screen_hotel.Margin = new System.Windows.Forms.Padding(2);
            this.Screen_hotel.Name = "Screen_hotel";
            this.Screen_hotel.RowHeadersWidth = 62;
            this.Screen_hotel.RowTemplate.Height = 33;
            this.Screen_hotel.Size = new System.Drawing.Size(803, 395);
            this.Screen_hotel.TabIndex = 35;
            this.Screen_hotel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Screen_hotel_CellContentClick);
            // 
            // ratingtext
            // 
            this.ratingtext.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ratingtext.Location = new System.Drawing.Point(121, 132);
            this.ratingtext.Name = "ratingtext";
            this.ratingtext.Size = new System.Drawing.Size(439, 34);
            this.ratingtext.TabIndex = 34;
            this.ratingtext.TextChanged += new System.EventHandler(this.ratingtext_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 32);
            this.label4.TabIndex = 33;
            this.label4.Text = "Hotel Id";
            // 
            // costparday
            // 
            this.costparday.AutoSize = true;
            this.costparday.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.costparday.Location = new System.Drawing.Point(0, 183);
            this.costparday.Name = "costparday";
            this.costparday.Size = new System.Drawing.Size(134, 32);
            this.costparday.TabIndex = 32;
            this.costparday.Text = "CostParDay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 31;
            this.label2.Text = "Rating";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(427, 290);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(133, 148);
            this.Delete.TabIndex = 27;
            this.Delete.Text = "delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(278, 290);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(144, 148);
            this.Update.TabIndex = 28;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(153, 290);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(120, 148);
            this.Search.TabIndex = 29;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(32, 290);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(116, 148);
            this.Add.TabIndex = 30;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // costpardaytext
            // 
            this.costpardaytext.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.costpardaytext.Location = new System.Drawing.Point(140, 183);
            this.costpardaytext.Name = "costpardaytext";
            this.costpardaytext.Size = new System.Drawing.Size(424, 34);
            this.costpardaytext.TabIndex = 26;
            this.costpardaytext.TextChanged += new System.EventHandler(this.costpardaytext_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 32);
            this.label5.TabIndex = 38;
            this.label5.Text = "Categorie Id";
            // 
            // categorie_id
            // 
            this.categorie_id.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categorie_id.Location = new System.Drawing.Point(138, 28);
            this.categorie_id.Name = "categorie_id";
            this.categorie_id.Size = new System.Drawing.Size(426, 34);
            this.categorie_id.TabIndex = 37;
            this.categorie_id.TextChanged += new System.EventHandler(this.categorie_id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nametext
            // 
            this.Nametext.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nametext.Location = new System.Drawing.Point(100, 84);
            this.Nametext.Name = "Nametext";
            this.Nametext.Size = new System.Drawing.Size(460, 34);
            this.Nametext.TabIndex = 39;
            this.Nametext.TextChanged += new System.EventHandler(this.Nametext_TextChanged);
            // 
            // Categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 450);
            this.Controls.Add(this.Nametext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.categorie_id);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Screen_hotel);
            this.Controls.Add(this.ratingtext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costparday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.costpardaytext);
            this.Name = "Categorie";
            this.Text = "Categorie";
            this.Load += new System.EventHandler(this.Categorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Screen_hotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private DataGridView Screen_hotel;
        private TextBox ratingtext;
        private Label label4;
        private Label costparday;
        private Label label2;
        private Button Delete;
        private Button Update;
        private Button Search;
        private Button Add;
        private TextBox costpardaytext;
        private Label label5;
        private TextBox categorie_id;
        private Label label1;
        private TextBox Nametext;
    }
}