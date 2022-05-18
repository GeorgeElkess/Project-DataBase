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
        private void Add_Click(object sender, EventArgs e)
        {
             if (nametext.Text != "" && ratingtext.Text != "" && addresstext.Text != "")
             {
                 List<List<string>> Datachec;
                 Datachec = dataBase.Read("Name= '" + nametext.Text+"'");
                 if (Datachec.Count == 0)
                 {
                    dataBase.Insert("'"+ nametext.Text + "', '" + addresstext.Text + "', '" + ratingtext.Text+"'");
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
                Datachec = dataBase.Read("Hotelid" + nametext.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("Hotelid = " + hotel_id.Text , "Name = '" + nametext.Text+"'");
                }
            }  
            else
            {
                Message.Error("UPDATE CAN'T BE DONE");
            }

            if (hotel_id.Text != "" && ratingtext.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("Hotelid" + ratingtext.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("Hotelid = " + hotel_id.Text , "Rating = '" + ratingtext.Text + "'");
                }
            }
            else
            {
                Message.Error("UPDATE CAN'T BE DONE");
            }
            if (hotel_id.Text != "" && addresstext.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("Hotelid" + addresstext.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("Hotelid = " + hotel_id.Text , "Address = '" + addresstext.Text + "'");
                }
            }
            else
            {
                Message.Error("UPDATE CAN'T BE DONE");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (hotel_id.Text != "")
            {
                dataBase.Delete("Hotelid= " + hotel_id.Text);
            }
            else
            {
                Message.Error("THIS ID IS NOT VALID SO THE DELETE CANT BE DONE");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if(nametext.Text != "" || ratingtext.Text != "" || addresstext.Text != ""|| hotel_id.Text != "")
            {
                if (hotel_id.Text != "")
                {
                    dataBase.Read("Hotelid= " + hotel_id.Text);
                    //dataBase.GetTable();
                }
                if (ratingtext.Text != "")
                {

                }
                if (addresstext.Text != "")
                {

                }
                if (nametext.Text != "")
                {

                }
            }
           
        }
    }
}
