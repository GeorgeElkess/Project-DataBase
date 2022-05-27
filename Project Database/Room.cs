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
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase("Room");
        public string GethotelId(string Name)
        {
            DataBase dataBase = new DataBase("Hotel");
            List<List<string>> x = dataBase.Read("Name = '" + Name + "'");
            return x[0][0];
        }
        public string GetCategorieId(string Name)
        {
            DataBase dataBase = new DataBase("Categorie");
            List<List<string>> x = dataBase.Read("Name = '" + Name + "'");
            return x[0][0];
        }
        private void Room_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void statetext_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void hotelId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hotelId.SelectedIndex == 0)
            {
                Categorieid.Items.Clear();
                Categorieid.Items.Add("Non");
                return;
            }
            string HotelName = hotelId.SelectedItem.ToString();
            string HotelId = GethotelId(HotelName);
            DataBase CatigoryData = new DataBase("Categorie");
            List<List<string>> x = CatigoryData.Read("HotelId = " + HotelId);
            Categorieid.Items.Clear();
            Categorieid.Items.Add("Non");
            foreach (var item in x)
            {
                Categorieid.Items.Add(item[1]);
            }
        }
        private void Categorieid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (statetext.Text != "" && roomnumber.Text != "" && hotelId.SelectedIndex != -1 && hotelId.SelectedIndex != 0 && Categorieid.SelectedIndex != -1 && Categorieid.SelectedIndex != 0)
            {
                dataBase.Insert($"'{statetext.Text}', '{roomnumber.Text}', {GethotelId(hotelId.SelectedItem.ToString())}, {GetCategorieId(Categorieid.SelectedItem.ToString())}");
            }
            else
            {
                Message.Error("error");
            }
        }
        private void Search_Click(object sender, EventArgs e)
        {
            List<string> Headrs = new List<string>();
            Headrs.Add("Roomid");
            Headrs.Add("State");
            Headrs.Add("RoomNumber");
            Headrs.Add("HotelName");
            Headrs.Add("CategorieName");
            string Condition = "";
            int t = 0;
            if (Room_id.Text != "")
            {
                Condition += "RoomId = " + Room_id.Text;
                t = 1;
            }
            if (statetext.Text != "")
            {
                Condition += (t == 1 ? "And " : "") + "State = '" + statetext.Text + "'";
                t = 1;
            }
            if (roomnumber.Text != "")
            {
                Condition += (t == 1 ? "And " : "") + "RoomNumber = '" + roomnumber.Text + "'";
                t = 1;
            }
            if (hotelId.SelectedIndex > 0)
            {
                Condition += (t == 1 ? "And " : "") + "HotelId = " + GethotelId(hotelId.SelectedItem.ToString());
                t = 1;
            }
            if (Categorieid.SelectedIndex > 0)
            {
                Condition += (t == 1 ? "And " : "") + "Categorield = " + GetCategorieId(Categorieid.SelectedItem.ToString());
                t = 1;
            }
            List<List<string>> vs = dataBase.Read(Condition);
            foreach (var item in vs)
            {
                string HotelId = item[3];
                DataBase HotelData = new DataBase("Hotel");
                string HotelName = HotelData.Read("HotelId = " + HotelId)[0][1];
                item[3] = HotelName;
                DataBase CatigoryData = new DataBase("Categorie");
                string CatigoryId = item[4];
                string CattigoryName = CatigoryData.Read("CategorieId = " + CatigoryId)[0][1];
                item[4] = CattigoryName;
            }
            Screen_hotel.DataSource = dataBase.GetTable(Headrs, vs);

        }
        void InicalizeState()
        {
            Room_id.Text = String.Empty;
            statetext.Text = String.Empty;
            roomnumber.Text = String.Empty;
            hotelId.SelectedIndex = 0;
            Categorieid.Items.Clear();
            Categorieid.Items.Add("Non");
            Categorieid.SelectedIndex = 0;
        }
        private void Screen_hotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Room_id.Text != "")
            {
                dataBase.Delete("RoomId= " + Room_id.Text);
            }
            else
            {
                Message.Error("THIS ID IS NOT VALID SO THE DELETE CANT BE DONE");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (Room_id.Text != "" && statetext.Text != "")
            {
                dataBase.Update("RoomId = " + Room_id.Text, "State = '" + statetext.Text + "'");
            }
            if (Room_id.Text != "" && roomnumber.Text != "")
            {
                dataBase.Update("RoomId = " + Room_id.Text, "RoomNumber = '" + roomnumber.Text + "'");
            }
            if (Room_id.Text != "" && hotelId.SelectedIndex != -1 && hotelId.SelectedIndex != 0)
            {
                dataBase.Update("RoomId = " + Room_id.Text, "Hotelid = " + GethotelId(hotelId.SelectedItem.ToString()));
            }
            if (Room_id.Text != "" && Categorieid.SelectedIndex != -1 && Categorieid.SelectedIndex != 0)
            {
                dataBase.Update("RoomId = " + Room_id.Text, "Categorield = " + GetCategorieId(Categorieid.SelectedItem.ToString()));
            }
        }

        private void Room_Load(object sender, EventArgs e)
        {
            DataBase HotelData = new DataBase("Hotel");
            List<List<string>> x = HotelData.Read();
            hotelId.Items.Clear();
            hotelId.Items.Add("Non");
            foreach (var item in x)
            {
                hotelId.Items.Add(item[1]);
            }
        }
    }
}
