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
    public partial class Trip : Form
    {
        DataBase data = new DataBase("Trip");
        public Trip()
        {
            InitializeComponent();
        }

        private void Trip_Load(object sender, EventArgs e)
        {
            List<string> Headers = new List<string>();
            Headers.Add("Trip Id");
            Headers.Add("Customer Id");
            Headers.Add("Employee Id");
            Headers.Add("Room Id");
            Headers.Add("Start Date");
            Headers.Add("End Date");
            dataGridView1.DataSource = data.GetTable(Headers, data.Read());
            DataBase Hotel = new DataBase("Hotel");
            List<List<string>> x = Hotel.Read();
            comboBox1.Items.Add("Non");
            foreach (List<string> item in x)
            {
                comboBox1.Items.Add(item[1]);
            }
            comboBox2.Items.Add("Non");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBase Hotel = new DataBase("Hotel");
            List<List<string>> HotelName = Hotel.Read("Name = '"+ comboBox2.SelectedItem.ToString() + "'");
            string HotelId = HotelName[0][0];
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Non");
            DataBase Room = new DataBase("Room");
            List<List<string>> Rooms = Room.Read("HotelId = " + HotelId);
            foreach (List<string> item in Rooms)
            {
                comboBox2.Items.Add(item[1]);
            }
        }
    }
}
