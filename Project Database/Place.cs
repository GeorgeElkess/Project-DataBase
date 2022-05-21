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
    public partial class Place : Form
    {
        public Place()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
        DataBase data = new DataBase("Place");
        string GetCountryId(string CountryName)
        {
            string Id = "";
            DataBase CountyData = new DataBase("Country");
            List<List<string>> x = CountyData.Read("Name = '" + CountryName + "'");
            Id = x[0][0];
            return Id;
        }
        private void Place_Load(object sender, EventArgs e)
        {
            DataBase CountyData = new DataBase("Country");
            List<List<string>> x = CountyData.Read();
            comboBox1.Items.Add("Non");
            for (int i = 0; i < x.Count; i++)
            {
                comboBox1.Items.Add(x[i][1]);
            }
            Headers.Add("Place Id");
            Headers.Add("Name");
            Headers.Add("Address");
            Headers.Add("Cost Per Hour");
            Headers.Add("Country Id");
            dataGridView1.DataSource = data.GetTable(Headers, data.Read());
        }
        void Initialize()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "") Message.Error("Name is required");
            else if (textBox3.Text == "") Message.Error("Address is required");
            else if (textBox4.Text == "") Message.Error("Price per hour is required");
            else if (comboBox1.SelectedIndex < 1) Message.Error("Country is required");
            else
            {
                string Name = textBox2.Text;
                string Address = textBox3.Text;
                string PricePerHour = textBox4.Text;
                string CountryId = GetCountryId(comboBox1.SelectedItem.ToString());
                if (data.Read("Name = '" + Name + "' and CountryId = " + CountryId).Count > 0) Message.Error("this Data already exsists");
                else
                {
                    if (Message.Inform("Data will be inserted"))
                    {
                        data.Insert("'" + Name + "', '" + Address + "', " + PricePerHour + ", " + CountryId);
                        Initialize();
                    }
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") Message.Error("Place Id is required");
            else if (Message.Inform("Data will be Deleted"))
            {
                data.Delete("PlaceId = " + textBox1.Text);
                Initialize();
            }
        }
        List<string> Headers = new List<string>();
        private void button3_Click(object sender, EventArgs e)
        {
            string Condition = "";
            if (textBox1.Text != "") Condition += "PlaceId = " + textBox1.Text;
            if (textBox2.Text != "") Condition += " Name = '" + textBox2.Text + "'";
            if (textBox3.Text != "") Condition += " Address = '" + textBox3.Text + "'";
            if (textBox4.Text != "") Condition += " CostParHour = " + textBox4.Text + "";
            if (comboBox1.SelectedIndex > 0) Condition += "CountryId = " + GetCountryId(comboBox1.SelectedItem.ToString());
            dataGridView1.DataSource = data.GetTable(Headers, data.Read(Condition));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { Message.Error("Place Id is required"); return; }
            string PlaceId = textBox1.Text;
            string Condition = "PlaceId = " + PlaceId;
            string Set = "";
            bool temp = false;
            if (textBox2.Text != "")
            {
                if (!temp) Set += "Name = '" + textBox2.Text + "'";
                else Set += ", Name = '" + textBox2.Text + "'";
                temp = true;
            }
            if (textBox3.Text != "")
            {
                if (!temp) Set += "Address = '" + textBox3.Text + "'";
                else Set += ", Address = '" + textBox3.Text + "'";
                temp = true;
            }
            if (textBox4.Text != "")
            {
                if (!temp) Set += "CostParHour = " + textBox4.Text;
                else Set += ", CostParHour = " + textBox4.Text;
                temp = true;
            }
            if (comboBox1.SelectedIndex > 0)
            {
                if (!temp) Set += "CountryId = " + GetCountryId(comboBox1.SelectedItem.ToString());
                else Set += ", CountryId = " + GetCountryId(comboBox1.SelectedItem.ToString());
                temp = true;
            }
            if (Message.Inform("Data will be Updated"))
            {
                data.Update(Condition, Set);
                Initialize();
            }
        }
    }
}

