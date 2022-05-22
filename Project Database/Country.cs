using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Database
{
    public partial class Country : Form
    {
        public Country()
        {
            InitializeComponent();
        }

        private void COUNTRY_RATE_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar)) e.Handled = true;

        }
        DataBase dataBase = new DataBase("Country");
        
        
        private void ADD_Click(object sender, EventArgs e)
        {
            
            if(COUNTRY_NAME.Text!=""&&COUNTRY_RATE.Text!="")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("Name='"+COUNTRY_NAME.Text + "'");
                if (Datachec.Count==0)
                {
                    dataBase.Insert("'"+COUNTRY_NAME.Text + "', " + COUNTRY_RATE.Text);
                }
                else
                {
                    Message.Error("Name IS Already Exist");
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=""&&COUNTRY_NAME.Text!="")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("CountryId=" + textBox1.Text);
                if(Datachec.Count!=0)
                {
                    dataBase.Update("CountryId = " + textBox1.Text, "Name = '" + COUNTRY_NAME.Text+"'");
                }
            }
            else if(textBox1.Text != "" && COUNTRY_RATE.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("CountryId=" + textBox1.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("CountryId = " + textBox1.Text, "Rating = " + COUNTRY_RATE.Text);
                }
            }
            else
            {
                Message.Error("UPDATE CANT BE DONE");
            }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                dataBase.Delete("CountryId=" + textBox1.Text);
            }
            else
            {
                Message.Error("THIS ID IS NOT VALID SO THE DELETE CANT BE DONE");
            }
        }

        
        private void SEARCH_Click(object sender, EventArgs e)
        {
            string condition;
        }

        private void Country_Load(object sender, EventArgs e)
        {

        }

        private void Country_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Country_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            
        }
    }
}
