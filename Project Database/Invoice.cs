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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
        DataBase data = new DataBase("Invoice");

        void Inisalize()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text = "1/1/2000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Date date1 = new Date(dateTimePicker1.Text);
            if (textBox2.Text == "") Message.Error("Trip Id is Required");
            else if (date1.ToFormatedString() == "1/1/2000") Message.Error("Date is Required");
            else
            {
                string TripId = textBox2.Text;
                Date date = new Date(dateTimePicker1.Text);
                if (Message.Inform("Data will be Inserted"))
                {
                    data.Insert(TripId + ", '" + date.ToFormatedString() + "'");
                    Inisalize();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") Message.Error("Invoice Id is Required");
            else
            {
                string Command = "InvoiceId = " + textBox1.Text;
                string Set = "";
                bool temp = false;
                if (textBox2.Text != "")
                {
                    if (!temp) Set += "TripId = " + textBox2.Text;
                    else Set += ", TripId = " + textBox2.Text;
                    temp = true;
                }
                Date date = new Date(dateTimePicker1.Text);
                if (date.ToFormatedString() == "1/1/2000")
                {
                    if (!temp) Set += "Date = '" + dateTimePicker1.Text + "'";
                    else Set += ", Date = '" + dateTimePicker1.Text + "'";
                    temp = true;
                }
                if (Message.Inform("Data Will be Updated"))
                {
                    data.Update(Command, Set);
                    Inisalize();
                }
            }
        }

        void MakeCondition(ref string Condition, string Add)
        {
            if (Condition == "") Condition += Add;
            else Condition += "And " + Add;
        }

        float GetTotalByTripId(string TripId)
        {
            float total = 0;
            DataBase TripData = new DataBase("Trip");
            List<List<string>> x = TripData.Read("TripId = " + TripId);
            Date StartingDate = Date.FromDataBase(x[0][4]);
            Date EndingDate = Date.FromDataBase(x[0][5]);
            long Duration = StartingDate - EndingDate;
            string RoomId = x[0][3];
            DataBase RoomsData = new DataBase("Room");
            string CatigoryId = RoomsData.Read("RoomId = " + RoomId)[0][4];
            DataBase CatigoryData = new DataBase("Categorie");
            float CostParDay = float.Parse(CatigoryData.Read("CategorieId = " + CatigoryId)[0][3]);
            total += Duration * CostParDay;
            DataBase VisitData = new DataBase("Visit");
            x = VisitData.Read("TripId = " + TripId);
            for (int i = 0; i < x.Count; i++)
            {
                DataBase PlaceData = new DataBase("Place");
                float CPD = float.Parse(PlaceData.Read("PlaceId = " + x[i][1])[0][3]);
                total += (CPD * float.Parse(x[i][3]));
            }
            return total;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string Condiion = "";
            Date date = new Date(dateTimePicker1.Text);
            if (textBox1.Text != "") MakeCondition(ref Condiion, "InvoiceId = " + textBox1.Text);
            else if (textBox2.Text != "") MakeCondition(ref Condiion, "TripId = " + textBox2.Text);
            else if (date.ToFormatedString() != "1/1/2000") MakeCondition(ref Condiion, "Date = '" + dateTimePicker1.Text + "'");
            List<List<string>> x = data.Read(Condiion);
            for (int i = 0; i < x.Count; i++)
            {
                string TripId = x[i][1];
                float Total = GetTotalByTripId(TripId);
                x[i].Add(Total.ToString());
            }
            List<string> Headers = new List<string>();
            Headers.Add("Invoice Id");
            Headers.Add("Trip Id");
            Headers.Add("Date");
            Headers.Add("Total");
            dataGridView1.DataSource = data.GetTable(Headers, x);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") Message.Error("Invoice Id is Required");
            else
            {
                string InvoiceId = textBox1.Text;
                if (data.Read("IncoiceId = " + InvoiceId).Count == 0) Message.Error("Invoice Id not exist");
                else
                {
                    if(Message.Inform("Data will be Deleted"))
                    {
                        data.Delete("IncoiceId = " + InvoiceId);
                        Inisalize();
                    }
                }
            }
        }

        private void Invoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();

        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            Inisalize();
        }
    }
}
