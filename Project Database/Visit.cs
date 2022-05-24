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
    public partial class Visit : Form
    {
        public Visit()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        void Initialize()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Tag = 0;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Text = "12:00:00 AM";
        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
        private void Visit_Load(object sender, EventArgs e)
        {
            c++;
            Initialize();
        }
        DataBase data = new DataBase("Visit");
        int c = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(c == 0) { c++; Initialize(); return; }
            if (textBox1.Text == "") Message.Error("Trip Id is Required");
            else if (textBox2.Text == "") Message.Error("Place Id is Required");
            else if (textBox4.Text == "") Message.Error("Duration is Required");
            else if (dateTimePicker1.Text == "12:00:00 AM") Message.Error("Time is Required");
            else
            {
                string TripId = textBox1.Text;
                string PlaceId = textBox2.Text;
                string Duration = textBox4.Text;
                string Time = dateTimePicker1.Text;
                DataBase TripData = new DataBase("Trip");
                DataBase PlaceData = new DataBase("Place");
                if (TripData.Read("TripId = " + TripId).Count == 0) Message.Error("Trip Id not exist");
                else if (PlaceData.Read("PlaceId = " + PlaceId).Count == 0) Message.Error("Place Id not exist");
                else if (data.Read("TripId = " + TripId + " And PlaceId = " + PlaceId).Count > 0) Message.Error("this visit already exist");
                else if (Message.Inform("Data Will Be inserted"))
                {
                    data.Insert(TripId + ", " + PlaceId + ", '" + Time + "', '" + Duration + "'");
                    Initialize();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") Message.Error("Trip Id is Required");
            else if (textBox2.Text == "") Message.Error("Place Id is Required");
            else 
            {
                string TripId = textBox1.Text;
                string PlaceId = textBox2.Text;
                if (data.Read("TripId = " + TripId + " And PlaceId = " + PlaceId).Count == 0) Message.Error("this visit Not exist");
                else
                {
                    string Condition = "TripId = " + TripId + " And PlaceId = " + PlaceId;
                    string Set = "";
                    bool temp = false;
                    if (dateTimePicker1.Text != "12:00:00 AM")
                    {
                        if (!temp) Set += "Time = '" + dateTimePicker1.Text + "'";
                        else Set += ", Time = '" + dateTimePicker1.Text + "'";
                    }
                    if (textBox4.Text != "")
                    {
                        if (!temp) Set += "Duration = '" + textBox4.Text + "'";
                        else Set += ", Duration = '" + textBox4.Text + "'";
                    }
                    if(Message.Inform("Data will be Updated \n" + Set))
                    {
                        data.Update(Condition, Set);
                        Initialize();
                    }
                }
            }
        }
        void MakeCondition(ref string Condition, string Add)
        {
            if (Condition == "") Condition += Add;
            else Condition += " and " + Add;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string Condition = "";
            if (textBox1.Text != "") MakeCondition(ref Condition, "TripId = " + textBox1.Text);
            if(textBox2.Text != "") MakeCondition(ref Condition,"PlaceId = " + textBox2.Text);
            if (textBox4.Text != "") MakeCondition(ref Condition, "Duration = '" + textBox4.Text + "'");
            if (dateTimePicker1.Text != "12:00:00 AM") MakeCondition(ref Condition, "Time = '" + dateTimePicker1.Text + "'");
            List<string> Headers = new List<string>();
            Headers.Add("Trip Id");
            Headers.Add("Place Id");
            Headers.Add("Time");
            Headers.Add("Duration");
            dataGridView1.DataSource = data.GetTable(Headers, data.Read(Condition));
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") Message.Error("Trip Id is Required");
            else if (textBox2.Text == "") Message.Error("Place Id is Required");
            else
            {
                string TripId = textBox1.Text;
                string PlaceId = textBox2.Text;
                if (data.Read("TripId = " + TripId + " And PlaceId = " + PlaceId).Count == 0) Message.Error("this visit Not exist");
                else
                {
                    if(Message.Inform("Data Will be Deleted"))
                    {
                        data.Delete("TripId = " + TripId + " And PlaceId = " + PlaceId);
                        Initialize();
                    }
                }
            }
        }

        private void Visit_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Visit_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
