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
    public partial class Hotell : Form
    {
        public Hotell()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase("Hotel");
        public string GetCountryId(string Name)
        {
            DataBase dataBase = new DataBase("Country");
            List<List<string>> x = dataBase.Read("Name = '" + Name + "'");
            return x[0][0];
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (nametext.Text != "" && ratingtext.Text != "" && addresstext.Text != "" && comboBox1.SelectedIndex != -1 && comboBox1.SelectedIndex != 0)
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("Name= '" + nametext.Text + "'");
                if (Datachec.Count == 0)
                {
                    dataBase.Insert("'" + nametext.Text + "', '" + addresstext.Text + "', '" + ratingtext.Text + "', " + GetCountryId(comboBox1.SelectedItem.ToString()));
                }
                else
                {
                    Message.Error("Name IS Already Exist");
                }
            }
        }

        private void hotel_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametext_TextChanged(object sender, EventArgs e)
        {

        }

        private void ratingtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void addresstext_TextChanged(object sender, EventArgs e)
        {

        }

        private void country_id_text_TextChanged(object sender, EventArgs e)
        {

        }
        private void Update_Click(object sender, EventArgs e)
        {
            if (hotel_id.Text != "" && nametext.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("HotelId = " + hotel_id.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("HotelId = " + hotel_id.Text, "Name = '" + nametext.Text + "'");
                }
            }
            if (hotel_id.Text != "" && ratingtext.Text != "")
            {
                dataBase.Update("HotelId = " + hotel_id.Text, "Rating = '" + ratingtext.Text + "'");
            }
            if (hotel_id.Text != "" && addresstext.Text != "")
            {
                dataBase.Update("HotelId = " + hotel_id.Text, "Address = '" + addresstext.Text + "'");
            }
            if (hotel_id.Text != "" && comboBox1.SelectedIndex != -1 && comboBox1.SelectedIndex != 0)
            {
                dataBase.Update("HotelId = " + hotel_id.Text, "CountryId = " + GetCountryId(comboBox1.SelectedItem.ToString()));
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (hotel_id.Text != "")
            {
                dataBase.Delete("HotelId= " + hotel_id.Text);
            }
            else
            {
                Message.Error("THIS ID IS NOT VALID SO THE DELETE CANT BE DONE");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            List<string> Headrs = new List<string>();
            Headrs.Add("HotelId");
            Headrs.Add("Name");
            Headrs.Add("Address");
            Headrs.Add("Rating");
            Headrs.Add("Countryid");
            string Condition = "";
            int t = 0;
            if (hotel_id.Text != "")
            {
                Condition += "HotelId = " + hotel_id.Text;
                t = 1;
            }
            if (ratingtext.Text != "")
            {
                Condition += (t == 1 ? "And " : "") + "Rating = " + ratingtext.Text;
                t = 1;
            }
            if (addresstext.Text != "")
            {
                Condition += (t == 1 ? "And " : "") + "Address = '" + addresstext.Text + "'";
                t = 1;
            }
            if (nametext.Text != "")
            {
                Condition += (t == 1 ? "And " : "") + "Name = '" + nametext.Text + "'";
                t = 1;
            }
            if (comboBox1.SelectedIndex > 0)
            {
                Condition += (t == 1 ? "And " : "") + "CountryId = " +GetCountryId( comboBox1.SelectedItem.ToString());
                t = 1;
            }
            Screen_hotel.DataSource = dataBase.GetTable(Headrs, dataBase.Read(Condition));

        }

        private void Screen_hotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Hotell_Load(object sender, EventArgs e)
        {
            DataBase Country = new DataBase("Country");
            List<List<string>> x = Country.Read();
            comboBox1.Items.Add("Non");
            for (int i = 0; i < x.Count; i++)
            {
                comboBox1.Items.Add(x[i][1]);
            }
        }
    }
}
