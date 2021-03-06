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
                    COUNTRY_NAME.Text = String.Empty;
                    COUNTRY_RATE.Text = String.Empty;
                    textBox1.Text = String.Empty;
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
                    COUNTRY_NAME.Text = String.Empty;
                    COUNTRY_RATE.Text = String.Empty;
                    textBox1.Text = String.Empty;
                }
            }
            else if(textBox1.Text != "" && COUNTRY_RATE.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("CountryId=" + textBox1.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("CountryId = " + textBox1.Text, "Rating = " + COUNTRY_RATE.Text);
                    COUNTRY_NAME.Text = String.Empty;
                    COUNTRY_RATE.Text = String.Empty;
                    textBox1.Text = String.Empty;
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
                COUNTRY_NAME.Text = String.Empty;
                COUNTRY_RATE.Text = String.Empty;
                textBox1.Text = String.Empty;
            }
            else
            {
                Message.Error("THIS ID IS NOT VALID SO THE DELETE CANT BE DONE");
            }
        }

        void MakeCondition(ref string Condition, string Add)
        {
            if (Condition == "") Condition += Add;
            else Condition += " and " + Add;
        }
        List<string> Headers = new List<string>();

        private void SEARCH_Click(object sender, EventArgs e)
        {
              string condition=""; 
            if (COUNTRY_NAME.Text!="")
            {
                MakeCondition(ref condition,"Name ='"+COUNTRY_NAME.Text+"'"); 
            }
            if(textBox1.Text!="")
            {
                MakeCondition(ref condition, "CountryId =" + textBox1.Text);
            }
            if (COUNTRY_RATE.Text!="")
            {
                MakeCondition(ref condition, "Rating='" + COUNTRY_RATE.Text+"'");
            }
            dataGridView1.DataSource = dataBase.GetTable(Headers, dataBase.Read(condition));
        }
        
        private void Country_Load(object sender, EventArgs e)
        {
            Headers.Add("Country ID");      
            Headers.Add("Country Name");
            Headers.Add("Country Rate");
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

        private void COUNTRY_NAME_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
