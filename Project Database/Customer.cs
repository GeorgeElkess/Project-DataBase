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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void Initialize()
        {
            Customer_ID.Text = String.Empty;
            First_Name.Text = String.Empty;
            Last_Name.Text = String.Empty;
            DateTime t = DateTime.Now;
            t = t.AddDays(1);
            Date_Of_Birth.Text = t.ToLongDateString();
            Passport_ID.Text = String.Empty;
            Address.Text = String.Empty;
            Sex.Text = String.Empty;
            Sex.SelectedIndex = -1;
            Sex.ClearSelected();
        }
        DataBase dataBase = new DataBase("Customer");
        private void ADD_Click(object sender, EventArgs e)
        {
            if (First_Name.Text != "" && Last_Name.Text != "" && Date_Of_Birth.Text != ""
               && Address.Text != "" && Passport_ID.Text != "" && Sex.Text != "" )
            {
                List<List<string>> datachec = new List<List<string>>();
                datachec = dataBase.Read("FirstName= '" + First_Name.Text + "'");
                if (datachec.Count == 0)
                {
                    Date date = new Date(Date_Of_Birth.Text);
                    dataBase.Insert("'" + First_Name.Text + "', '" + Last_Name.Text + "', '" + Sex.SelectedItem.ToString()+"', '" + date.ToFormatedString() + "', '" +
                        Address.Text + "', '" + Passport_ID.Text + "', '" + Sex.Text + "'");
                    Initialize();
                }
                else
                {
                    Message.Error("This Employee IS Already Exist");
                }
            }
            else Message.Error("Can't be Add");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Customer_ID.Text != "")
            {
                dataBase.Delete("CustomerId=" + Customer_ID.Text);
                Initialize();
            }
            else
            {
                Message.Error("THIS ID IS NOT VALID SO THE DELETE CAN'T BE DONE");
            }
        }
        void MakeCondition(ref string Condition, string Add)
        {
            if (Condition == "") Condition += Add;
            else Condition += " and " + Add;
        }
        List<string> Headers = new List<string>();
        private void Search_Click(object sender, EventArgs e)
        {
            string condition = "";
            if (Customer_ID.Text != "")
            {
                MakeCondition(ref condition, "CustomerId =" + Customer_ID.Text);
            }
            if (First_Name.Text != "")
            {
                MakeCondition(ref condition, "FirstName ='" + First_Name.Text + "'");
            }
            if (Last_Name.Text != "")
            {
                MakeCondition(ref condition, "LastName='" + Last_Name.Text + "'");
            }
            DateTime t = DateTime.Now;
            t = t.AddDays(1);
            if (Date_Of_Birth.Text != t.ToLongDateString())
            {
                Date date = new Date(Date_Of_Birth.Text);
                MakeCondition(ref condition, "DateOfBirth='" + date.ToFormatedString() + "'");
            }
            if (Address.Text != "")
            {
                MakeCondition(ref condition, "Address='" + Address.Text + "'");
            }
            if (Sex.Text != "")
            {
                MakeCondition(ref condition, "Sex='" + Sex.Text + "'");
            }
            if (Passport_ID.Text != "")
            {
                MakeCondition(ref condition, "PassPortId='" + Passport_ID.Text + "'");
            }
            List<List<string>> x = dataBase.Read(condition);
            Screen_hotel.DataSource = dataBase.GetTable(Headers, x);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (Customer_ID.Text != "" && First_Name.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("CustomerId=" + Customer_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("CustomerId = " + Customer_ID.Text, "FirstName = '" + First_Name.Text + "'");
                }
            }
            if (Customer_ID.Text != "" && Last_Name.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("CustomerId=" + Customer_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("CustomerId = " + Customer_ID.Text, "LastName = '" + Last_Name.Text + "'");
                }
            }
            DateTime t = DateTime.Now;
            t = t.AddDays(1);
            if (Customer_ID.Text != "" && Date_Of_Birth.Text != t.ToLongDateString())
            {
                Date date = new Date(Date_Of_Birth.Text);
                List<List<string>> Datachec;
                Datachec = dataBase.Read("CustomerId=" + Customer_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("CustomerId = " + Customer_ID.Text, "DateOfBirth = '" + date.ToFormatedString() + "'");
                }
            }

            if (Customer_ID.Text != "" && Address.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("CustomerId=" + Customer_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("CustomerId = " + Customer_ID.Text, "Address = '" + Address.Text + "'");
                }
            }
            if (Customer_ID.Text != "" && Sex.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("CustomerId=" + Customer_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("CustomerId = " + Customer_ID.Text, "Sex = '" + Sex.Text + "'");
                }
            }
            if (Customer_ID.Text != "" && Passport_ID.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("CustomerId=" + Customer_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("CustomerId = " + Customer_ID.Text, "PassPortId = '" + Passport_ID.Text + "'");
                }
            }
            Initialize();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            Headers.Add("Customer Id");
            Headers.Add("First Name");
            Headers.Add("Last Name");
            Headers.Add("Sex");
            Headers.Add("Date of Birth");
            Headers.Add("Address");
            Headers.Add("Passport Id");
           Initialize();
        }
    }
}
