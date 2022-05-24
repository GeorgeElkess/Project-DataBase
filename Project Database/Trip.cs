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
            Headers.Add("Hotel Name");
            Headers.Add("Room Number");
            Headers.Add("Start Date");
            Headers.Add("End Date");
            List<List<string>> x = data.Read();
            for (int i = 0; i < x.Count; i++)
            {
                string RoomId = x[i][3];
                DataBase RoomData = new DataBase("Room");
                string RoomNumber = RoomData.Read("RoomId = " + RoomId) [0][2];
                x[i][3] = RoomNumber;
                string CatigoryId = RoomData.Read("RoomId = " + RoomId)[0][4];
                DataBase CatigoryData = new DataBase("Categorie");
                string HotelId = CatigoryData.Read("CategorieId = " + CatigoryId)[0][4];
                DataBase HotelData = new DataBase("Hotel");
                string HotelName = HotelData.Read("HotelId = " + HotelId)[0][1];
                x[i].Insert(3, HotelName);
            }
            dataGridView1.DataSource = data.GetTable(Headers, x);
            DataBase Hotel = new DataBase("Hotel");
            x = Hotel.Read();
            comboBox1.Items.Add("Non");
            foreach (List<string> item in x)
            {
                comboBox1.Items.Add(item[1]);
            }
            comboBox2.Items.Add("Non");
            Initialize();
        }

        void Initialize()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            dateTimePicker1.Text = "1/1/2000";
            dateTimePicker2.Text = "1/1/2000";
        }

        void MakeCondition(ref string Condition, string Add)
        {
            if (Condition == "") Condition += Add;
            else Condition += " and " + Add;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) return;
            DataBase Hotel = new DataBase("Hotel");
            List<List<string>> HotelName = Hotel.Read("Name = '" + comboBox1.SelectedItem.ToString() + "'");
            string HotelId = HotelName[0][0];
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Non");
            DataBase Room = new DataBase("Room");
            List<List<string>> Rooms = Room.Read("HotelId = " + HotelId);
            foreach (List<string> item in Rooms)
            {
                comboBox2.Items.Add(item[2]);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Date StartingDate = new Date(dateTimePicker1.Text);
            Date EndingDate = new Date(dateTimePicker2.Text);
            if (textBox2.Text == "") Message.Error("Must Enter Customer Id");
            else if (textBox3.Text == "") Message.Error("Must Enter Employee Id");
            else if (comboBox1.SelectedIndex < 1) Message.Error("Must Enter Hotel Name");
            else if (comboBox2.SelectedIndex < 1) Message.Error("Must Enter Room Number");
            else if (StartingDate.ToFormatedString() == "1/1/2000") Message.Error("Must Enter Starting Date");
            else if (EndingDate.ToFormatedString() == "1/1/2000") Message.Error("Must Enter Ending Date");
            else if (EndingDate < StartingDate) Message.Error("Ending Date must be after the starting Date");
            else
            {
                string CustomerId = textBox2.Text;
                string EmployeeId = textBox3.Text;
                DataBase HotelData = new DataBase("Hotel");
                List<List<string>> HotelName = HotelData.Read("Name = '" + comboBox1.SelectedItem.ToString() + "'");
                string HotelId = HotelName[0][0];
                string RoomNumber = comboBox2.SelectedItem.ToString();
                DataBase CustomerData = new DataBase("Customer");
                if (CustomerData.Read("CustomerId = " + CustomerId).Count == 0)
                {
                    Message.Error("Customer Id not exsist");
                    return;
                }
                DataBase EmployeeData = new DataBase("Employee");
                if (EmployeeData.Read("EmployeeId = " + EmployeeId).Count == 0)
                {
                    Message.Error("Employee Id not exsist");
                    return;
                }
                DataBase RoomData = new DataBase("Room");
                List<List<string>> RoomName = RoomData.Read("RoomNumber = '" + RoomNumber + "'");
                string RoomId = RoomName[0][0];
                if (Message.Inform("Data will be Inserted"))
                {
                    data.Insert(CustomerId + ", " + EmployeeId + ", " + RoomId + ", '" + StartingDate.ToFormatedString() + "', '" + EndingDate.ToFormatedString() + "'");
                    Initialize();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                Message.Error("Trip Id is required");
                return;
            }
            string TripId = textBox1.Text;
            if (data.Read("TripId = " + TripId).Count == 0)
            {
                Message.Error("Trip Id no exist");
                return;
            }
            if (textBox2.Text != "")
            {
                string CustomerId = textBox2.Text;
                DataBase CustomerData = new DataBase("Customer");
                if (CustomerData.Read("CustomerId = " + CustomerId).Count == 0) Message.Error("Customer Id no exist");
                else data.Update("TripId = " + TripId, "CustomerId = " + CustomerId);
            }
            if (textBox3.Text != "")
            {
                string EmployeeId = textBox2.Text;
                DataBase EmployeeData = new DataBase("Employee");
                if (EmployeeData.Read("EmployeeId = " + EmployeeId).Count == 0) Message.Error("Employee Id no exist");
                else data.Update("TripId = " + TripId, "EmployeeId = " + EmployeeId);
            }
            if (comboBox2.SelectedIndex > 0)
            {
                string RoomNumber = comboBox2.SelectedItem.ToString();
                DataBase RoomData = new DataBase("Room");
                List<List<string>> RoomName = RoomData.Read("RoomNumber = '" + RoomNumber + "'");
                string RoomId = RoomName[0][0];
                data.Update("TripId = " + TripId, "RoomId = " + RoomId);
            }
            Date StartingDate = new Date(dateTimePicker1.Text);
            Date EndingDate = new Date(dateTimePicker2.Text);
            if (StartingDate.ToFormatedString() != "1/1/2000" && EndingDate.ToFormatedString() != "1/1/2000")
            {
                if (EndingDate < StartingDate) Message.Error("Ending Date must be after the starting Date");
                else data.Update("TripId = " + TripId, "StartDate = '" + StartingDate.ToFormatedString() + "', EndDate = '" + EndingDate.ToFormatedString() + "'");
            }
            else if (StartingDate.ToFormatedString() != "1/1/2000")
            {
                List<List<string>> x = data.Read("TripId = " + TripId);
                Date EndDate = Date.FromDataBase(x[0][5]);
                if (StartingDate > EndDate) Message.Error("Starting Date must be befor Ending Date");
                else data.Update("TripId = " + TripId, "StartDate = '" + StartingDate.ToFormatedString() + "'");
            }
            else if (EndingDate.ToFormatedString() != "1/1/2000")
            {
                List<List<string>> x = data.Read("TripId = " + TripId);
                Date StartDate = Date.FromDataBase(x[0][4]);
                if (EndingDate < StartDate) Message.Error("Ending Date must be after Starting Date");
                else data.Update("TripId = " + TripId, "EndDate = '" + EndingDate.ToFormatedString() + "'");
            }
            Initialize();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> Headers = new List<string>();
            Headers.Add("Trip Id");
            Headers.Add("Customer Id");
            Headers.Add("Employee Id");
            Headers.Add("Hotel Name");
            Headers.Add("Room Number");
            Headers.Add("Start Date");
            Headers.Add("End Date");
            string Condition = "";
            if (textBox1.Text != "") MakeCondition(ref Condition, "TripId = " + textBox1.Text + " ");
            if (textBox2.Text != "") MakeCondition(ref Condition, "CustomerId = " + textBox2.Text + " ");
            if (textBox3.Text != "") MakeCondition(ref Condition, "EmployeeId = " + textBox3.Text + " ");
            if (comboBox1.SelectedIndex > 0)
            {
                DataBase HotelData = new DataBase("Hotel");
                List<List<string>> HotelName = HotelData.Read("Name = '" + comboBox1.SelectedItem.ToString() + "'");
                string HotelId = HotelName[0][0];
                DataBase RoomData = new DataBase("Room");
                List<List<string>> Rooms = RoomData.Read("HotelId = " + HotelId);
                List<List<string>> Trips = data.Read();
                bool flag = false;
                for (int i = 0; i < Trips.Count; i++)
                {
                    bool IsThere = false;
                    for (int j = 0; j < Rooms.Count; j++)
                    {
                        if (Rooms[j][0] == Trips[i][3])
                        {
                            if (!flag) MakeCondition(ref Condition, "(RoomId = " + Rooms[j][0]);
                            else Condition += " or RoomId = " + Rooms[j][0] + " ";
                            flag = true;
                        }
                    }
                    if (!IsThere) Trips.RemoveAt(i--);
                }
                if (flag) Condition += ") ";
                else MakeCondition(ref Condition, "TripId = 0");
            }
            if (comboBox2.SelectedIndex > 0)
            {
                string RoomNumber = comboBox2.SelectedItem.ToString();
                DataBase RoomData = new DataBase("Room");
                List<List<string>> RoomName = RoomData.Read("RoomNumber = '" + RoomNumber + "'");
                string RoomId = RoomName[0][0];
                MakeCondition(ref Condition, "RoomId = " + RoomId + " ");
            }
            Date StartingDate = new Date(dateTimePicker1.Text);
            Date EndingDate = new Date(dateTimePicker2.Text);
            if (StartingDate.ToFormatedString() != "1/1/2000") Condition += "StartDate = '" + StartingDate.ToFormatedString() + "'";
            if (EndingDate.ToFormatedString() != "1/1/2000") Condition += "EndDate = '" + EndingDate.ToFormatedString() + "'";
            List<List<string>> x = data.Read(Condition);
            for (int i = 0; i < x.Count; i++)
            {
                string RoomId = x[i][3];
                DataBase RoomData = new DataBase("Room");
                string RoomNumber = RoomData.Read("RoomId = " + RoomId)[0][2];
                x[i][3] = RoomNumber;
                string CatigoryId = RoomData.Read("RoomId = " + RoomId)[0][4];
                DataBase CatigoryData = new DataBase("Categorie");
                string HotelId = CatigoryData.Read("CategorieId = " + CatigoryId)[0][4];
                DataBase HotelData = new DataBase("Hotel");
                string HotelName = HotelData.Read("HotelId = " + HotelId)[0][1];
                x[i].Insert(3, HotelName);
            }
            dataGridView1.DataSource = data.GetTable(Headers, x);
            Initialize();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                Message.Error("Trip Id is required");
                return;
            }
            string TripId = textBox1.Text;
            if (data.Read("TripId = " + TripId).Count == 0)
            {
                Message.Error("Trip Id no exist");
                return;
            }
            data.Delete("TripId = " + TripId);
            Initialize();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Trip_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Trip_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
