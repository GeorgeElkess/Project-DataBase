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
        }
        public string GetHotelid(string Name)
        {
            DataBase dataBase = new DataBase("Hotel");
            List<List<string>> x = dataBase.Read("Name = '" + Name + "'");
            return x[0][0];
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (costpardaytext.Text != "" && ratingtext.Text != "" && comboBox1.SelectedIndex != -1 && comboBox1.SelectedIndex != 0&& categorie_id.Text!="")
            {
                dataBase.Insert("'" + categorie_id.Text + "', '" + costpardaytext.Text + "', " + "', '" + ratingtext.Text + "', " + GetHotelid(comboBox1.SelectedItem.ToString()));
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
            Headrs.Add("Rating");
            Headrs.Add("CostParDay");
            Headrs.Add("Hotelid");
            string Condition = "";
            int t = 0;
            if (categorie_id.Text != "")
            {
                Condition += "CategorieId = " + categorie_id.Text;
                t = 1;
            }
            if (ratingtext.Text != "")
            {
                Condition += (t == 1 ? "And " : "") + "Rating = " + ratingtext.Text;
                t = 1;
            }
            if (costpardaytext.Text != "")
            {
                Condition += (t == 1 ? "And " : "") + "CostParDay = '" + costpardaytext.Text + "'";
                t = 1;
            }
            if (comboBox1.SelectedIndex > 0)
            {
                Condition += (t == 1 ? "And " : "") + "Hotelid = " + GetHotelid(comboBox1.SelectedItem.ToString());
                t = 1;
            }
            Screen_hotel.DataSource = dataBase.GetTable(Headrs, dataBase.Read(Condition));

        }

        private void categorie_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (categorie_id.Text != "")
            {
                dataBase.Delete("CategorieId= " + categorie_id.Text);
            }
            else
            {
                Message.Error("THIS ID IS NOT VALID SO THE DELETE CANT BE DONE");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            
            if (categorie_id.Text != "" && ratingtext.Text != "")
            {
                dataBase.Update("CategorieId = " + categorie_id.Text, "Rating = '" + ratingtext.Text + "'");
            }
            if (categorie_id.Text != "" && costpardaytext.Text != "")
            {
                dataBase.Update("CategorieId = " + categorie_id.Text, "CostParDay = '" + costpardaytext.Text + "'");
            }
            if (categorie_id.Text != "" && comboBox1.SelectedIndex != -1 && comboBox1.SelectedIndex != 0)
            {
                dataBase.Update("CategorieId = " + categorie_id.Text, "CountryId = " + GetHotelid(comboBox1.SelectedItem.ToString()));
            }
        }

        private void Screen_hotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
