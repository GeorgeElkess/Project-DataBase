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
    public partial class Categorie : Form
    {
        public Categorie()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase("Categorie");
        private void Categorie_Load(object sender, EventArgs e)
        {
            DataBase Country = new DataBase("Hotel");
            List<List<string>> x = Country.Read();
            comboBox1.Items.Add("Non");
            for (int i = 0; i < x.Count; i++)
            {
                comboBox1.Items.Add(x[i][1]);
            }
            Initalize();
        }
        public string GetHotelid(string Name)
        {
            DataBase dataBase = new DataBase("Hotel");
            List<List<string>> x = dataBase.Read("Name = '" + Name + "'");
            return x[0][0];
        }
        void Initalize()
        {
            Nametext.Text = String.Empty;
            costpardaytext.Text = String.Empty;
            ratingtext.Text = String.Empty;
            comboBox1.SelectedIndex = 0;
            categorie_id.Text = String.Empty;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (Nametext.Text!="" && costpardaytext.Text != "" && ratingtext.Text != "" && comboBox1.SelectedIndex != -1 && comboBox1.SelectedIndex != 0)
            {
                dataBase.Insert($"'{Nametext.Text}', '{ratingtext.Text}', {costpardaytext.Text}, {GetHotelid(comboBox1.SelectedItem.ToString())}");
                Initalize();
            }
            else
            {
                Message.Error("Error");
            }
        }
        private void costpardaytext_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ratingtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            List<string> Headrs = new List<string>();
            Headrs.Add("CategorieId");
            Headrs.Add("Name");
            Headrs.Add("Rating");
            Headrs.Add("CostParDay");
            Headrs.Add("Hotel Name");
            string Condition = "";
            int t = 0;
            if (categorie_id.Text != "")
            {
                Condition += "CategorieId = " + categorie_id.Text;
                t = 1;
            }
            if (Nametext.Text != "")
            {
                Condition += "Name = '" + Nametext.Text + "'";
                t = 1;
            }
            if (ratingtext.Text != "")
            {
                Condition += (t == 1 ? "And " : "") + "Rating = '" + ratingtext.Text + "'";
                t = 1;
            }
            if (costpardaytext.Text != "")
            {
                Condition += (t == 1 ? "And " : "") + "CostParDay = " + costpardaytext.Text;
                t = 1;
            }
            if (comboBox1.SelectedIndex > 0)
            {
                Condition += (t == 1 ? "And " : "") + "Hotelid = " + GetHotelid(comboBox1.SelectedItem.ToString());
                t = 1;
            }
            List<List<string>> x = dataBase.Read(Condition);
            foreach (var item in x)
            {
                string HotelId = item[4];
                DataBase HotelData = new DataBase("Hotel");
                string HotelName = HotelData.Read("HotelId = " + HotelId)[0][1];
                item[4] = HotelName;
            }
            Screen_hotel.DataSource = dataBase.GetTable(Headrs, x);
            Initalize();
        }

        private void categorie_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (categorie_id.Text != "")
            {
                dataBase.Delete("CategorieId= " + categorie_id.Text);
                Initalize();
            }
            else
            {
                Message.Error("THIS ID IS NOT VALID SO THE DELETE CANT BE DONE");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (categorie_id.Text != "" && Nametext.Text != "")
            {
                dataBase.Update("CategorieId = " + categorie_id.Text, "Name = '" + Nametext.Text + "'");
            }
            if (categorie_id.Text != "" && ratingtext.Text != "")
            {
                dataBase.Update("CategorieId = " + categorie_id.Text, "Rating = '" + ratingtext.Text + "'");
            }
            if (categorie_id.Text != "" && costpardaytext.Text != "")
            {
                dataBase.Update("CategorieId = " + categorie_id.Text, "CostParDay = " + costpardaytext.Text);
            }
            if (categorie_id.Text != "" && comboBox1.SelectedIndex != -1 && comboBox1.SelectedIndex != 0)
            {
                dataBase.Update("CategorieId = " + categorie_id.Text, "HotelId = " + GetHotelid(comboBox1.SelectedItem.ToString()));
            }
            Initalize();
        }

        private void Screen_hotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nametext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
