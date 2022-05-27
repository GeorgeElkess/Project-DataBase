namespace Project_Database
{
    partial class Room
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
            this.hotelId = new System.Windows.Forms.ComboBox();
            this.Categorieid = new System.Windows.Forms.ComboBox();
            this.Screen_hotel = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.roomnumber = new System.Windows.Forms.TextBox();
            this.statetext = new System.Windows.Forms.TextBox();
            this.Room_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Screen_hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelId
            // 
            this.hotelId.FormattingEnabled = true;
            this.hotelId.Location = new System.Drawing.Point(243, 415);
            this.hotelId.Name = "hotelId";
            this.hotelId.Size = new System.Drawing.Size(567, 33);
            this.hotelId.TabIndex = 54;
            this.hotelId.SelectedIndexChanged += new System.EventHandler(this.hotelId_SelectedIndexChanged);
            // 
            // Categorieid
            // 
            this.Categorieid.FormattingEnabled = true;
            this.Categorieid.Location = new System.Drawing.Point(243, 510);
            this.Categorieid.Name = "Categorieid";
            this.Categorieid.Size = new System.Drawing.Size(567, 33);
            this.Categorieid.TabIndex = 55;
            this.Categorieid.SelectedIndexChanged += new System.EventHandler(this.Categorieid_SelectedIndexChanged);
            // 
            // Screen_hotel
            // 
            this.Screen_hotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Screen_hotel.Location = new System.Drawing.Point(846, 78);
            this.Screen_hotel.Name = "Screen_hotel";
            this.Screen_hotel.RowHeadersWidth = 62;
            this.Screen_hotel.RowTemplate.Height = 33;
            this.Screen_hotel.Size = new System.Drawing.Size(1226, 658);
            this.Screen_hotel.TabIndex = 53;
            this.Screen_hotel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Screen_hotel_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(57, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 48);
            this.label5.TabIndex = 52;
            this.label5.Text = "Room Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(63, 405);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 48);
            this.label3.TabIndex = 50;
            this.label3.Text = "Hotel Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 497);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 48);
            this.label4.TabIndex = 51;
            this.label4.Text = "Categorie Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 96);
            this.label2.TabIndex = 49;
            this.label2.Text = " Room\r\nNumber";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.state.Location = new System.Drawing.Point(70, 168);
            this.state.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(99, 48);
            this.state.TabIndex = 48;
            this.state.Text = "State";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(623, 607);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(189, 130);
            this.Delete.TabIndex = 44;
            this.Delete.Text = "delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(410, 607);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(204, 130);
            this.Update.TabIndex = 45;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(231, 607);
            this.Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(170, 130);
            this.Search.TabIndex = 46;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(59, 607);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(164, 130);
            this.Add.TabIndex = 47;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // roomnumber
            // 
            this.roomnumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomnumber.Location = new System.Drawing.Point(209, 295);
            this.roomnumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomnumber.Name = "roomnumber";
            this.roomnumber.Size = new System.Drawing.Size(606, 47);
            this.roomnumber.TabIndex = 41;
            this.roomnumber.TextChanged += new System.EventHandler(this.roomnumber_TextChanged);
            // 
            // statetext
            // 
            this.statetext.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statetext.Location = new System.Drawing.Point(191, 177);
            this.statetext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statetext.Name = "statetext";
            this.statetext.Size = new System.Drawing.Size(624, 47);
            this.statetext.TabIndex = 42;
            this.statetext.TextChanged += new System.EventHandler(this.statetext_TextChanged);
            // 
            // Room_id
            // 
            this.Room_id.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Room_id.Location = new System.Drawing.Point(209, 88);
            this.Room_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Room_id.Name = "Room_id";
            this.Room_id.Size = new System.Drawing.Size(607, 47);
            this.Room_id.TabIndex = 43;
            this.Room_id.TextChanged += new System.EventHandler(this.Room_id_TextChanged);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 815);
            this.Controls.Add(this.hotelId);
            this.Controls.Add(this.Categorieid);
            this.Controls.Add(this.Screen_hotel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.state);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.roomnumber);
            this.Controls.Add(this.statetext);
            this.Controls.Add(this.Room_id);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Screen_hotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox hotelId;
        private ComboBox Categorieid;
        private DataGridView Screen_hotel;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label state;
        private Button Delete;
        private Button Update;
        private Button Search;
        private Button Add;
        private TextBox roomnumber;
        private TextBox statetext;
        private TextBox Room_id;
    }
}