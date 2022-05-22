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

        }

        private void Categorieid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Room_id.Text != "" && statetext.Text != "" && roomnumber.Text != "" && hotelId.SelectedIndex != -1 && hotelId.SelectedIndex != 0 && Categorieid.SelectedIndex != -1 && Categorieid.SelectedIndex != 0)
            {
                dataBase.Insert("'" + Room_id.Text + "', '" + statetext.Text + "', " + "', '" + roomnumber.Text + "', " + GethotelId(hotelId.SelectedItem.ToString()) + "," + GetCategorieId(Categorieid.SelectedItem.ToString()));
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
            Headrs.Add("Hotelid");
            Headrs.Add("Categorield");
            string Condition = "";
            int t = 0;
            if (Room_id.Text != "")
            {
                Condition += "Roomid = " + Room_id.Text;
                t = 1;
            }
            if (statetext.Text != "")
            {
                Condition += (t == 1 ? "And " : "") + "State = " + statetext.Text;
                t = 1;
            }
            if (roomnumber.Text != "")
            {
                Condition += (t == 1 ? "And " : "") + "RoomNumber = '" + roomnumber.Text + "'";
                t = 1;
            }
            if (hotelId.SelectedIndex > 0)
            {
                Condition += (t == 1 ? "And " : "") + "Hotelid = " + GethotelId(hotelId.SelectedItem.ToString());
                t = 1;
            }
            if (Categorieid.SelectedIndex > 0)
            {
                Condition += (t == 1 ? "And " : "") + "Categorield = " + GetCategorieId(Categorieid.SelectedItem.ToString());
                t = 1;
            }
            Screen_hotel.DataSource = dataBase.GetTable(Headrs, dataBase.Read(Condition));

        }

        private void Screen_hotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Room_id.Text != "")
            {
                dataBase.Delete("Roomid= " + Room_id.Text);
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
                dataBase.Update("HotelId = " + Room_id.Text, "State = '" + statetext.Text + "'");
            }
            if (Room_id.Text != "" && roomnumber.Text != "")
            {
                dataBase.Update("HotelId = " + Room_id.Text, "RoomNumber = '" + roomnumber.Text + "'");
            }
            if (Room_id.Text != "" && hotelId.SelectedIndex != -1 && hotelId.SelectedIndex != 0)
            {
                dataBase.Update("HotelId = " + Room_id.Text, "Hotelid = " + GethotelId(hotelId.SelectedItem.ToString()));
            }
            if (Room_id.Text != "" && Categorieid.SelectedIndex != -1 && Categorieid.SelectedIndex != 0)
            {
                dataBase.Update("HotelId = " + Room_id.Text, "Categorield = " + GetCategorieId(Categorieid.SelectedItem.ToString()));
            }
        }
    }
}
