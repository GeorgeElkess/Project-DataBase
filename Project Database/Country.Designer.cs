namespace Project_Database
{
    partial class Country
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
            this.COUNTRY_NAME = new System.Windows.Forms.TextBox();
            this.ADD = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.SEARCH = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.COUNTRY_RATE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.COUNTRY_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // COUNTRY_NAME
            // 
            this.COUNTRY_NAME.Location = new System.Drawing.Point(846, 77);
            this.COUNTRY_NAME.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.COUNTRY_NAME.Name = "COUNTRY_NAME";
            this.COUNTRY_NAME.Size = new System.Drawing.Size(219, 31);
            this.COUNTRY_NAME.TabIndex = 0;
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(43, 437);
            this.ADD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(115, 36);
            this.ADD.TabIndex = 1;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(207, 437);
            this.UPDATE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(115, 36);
            this.UPDATE.TabIndex = 2;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // SEARCH
            // 
            this.SEARCH.Location = new System.Drawing.Point(378, 437);
            this.SEARCH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(115, 36);
            this.SEARCH.TabIndex = 3;
            this.SEARCH.Text = "SEARCH";
            this.SEARCH.UseVisualStyleBackColor = true;
            this.SEARCH.Click += new System.EventHandler(this.SEARCH_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(554, 437);
            this.DELETE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(115, 36);
            this.DELETE.TabIndex = 4;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(764, 332);
            this.dataGridView1.TabIndex = 5;
            // 
            // COUNTRY_RATE
            // 
            this.COUNTRY_RATE.Location = new System.Drawing.Point(846, 302);
            this.COUNTRY_RATE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.COUNTRY_RATE.Name = "COUNTRY_RATE";
            this.COUNTRY_RATE.Size = new System.Drawing.Size(219, 31);
            this.COUNTRY_RATE.TabIndex = 6;
            this.COUNTRY_RATE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.COUNTRY_RATE_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(846, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "COUNTRY NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(846, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "COUNTRY RATE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(846, 188);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 31);
            this.textBox1.TabIndex = 9;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // COUNTRY_ID
            // 
            this.COUNTRY_ID.AutoSize = true;
            this.COUNTRY_ID.Location = new System.Drawing.Point(846, 148);
            this.COUNTRY_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.COUNTRY_ID.Name = "COUNTRY_ID";
            this.COUNTRY_ID.Size = new System.Drawing.Size(115, 25);
            this.COUNTRY_ID.TabIndex = 10;
            this.COUNTRY_ID.Text = "COUNTRY ID";
            // 
            // Country
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 727);
            this.Controls.Add(this.COUNTRY_ID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.COUNTRY_RATE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.SEARCH);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.COUNTRY_NAME);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Country";
            this.Text = "Country";
            this.Load += new System.EventHandler(this.Country_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox COUNTRY_NAME;
        private Button ADD;
        private Button UPDATE;
        private Button SEARCH;
        private Button DELETE;
        private DataGridView dataGridView1;
        private TextBox COUNTRY_RATE;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label COUNTRY_ID;
    }
}