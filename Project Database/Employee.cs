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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
        DataBase dataBase = new DataBase("Employee");
        private void Add_Click(object sender, EventArgs e)
        {
            if(First_Name.Text!=""&&Last_Name.Text!=""&&Date_Of_Birth.Text!=""
                &&Address.Text!=""&&Job_Title.Text!=""&&Salary.Text!=""&&Working_Hours.Text!="")
            {
                List<List<string>> datachec = new List<List<string>>();
                datachec = dataBase.Read("First Name= '" + First_Name.Text + "'");
                if(datachec.Count == 0)
            {
                    dataBase.Insert("'" + First_Name.Text + "', " + Last_Name.Text + "', " + Date_Of_Birth.Text + "', " +
                        Address.Text + "', " + Job_Title.Text + "', " + Salary.Text + "', " + Working_Hours.Text + "', ");
                }
                else
                {
                    Message.Error("This Employee IS Already Exist");
                }
            }
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Employee_ID.Text!= "")
            {
                dataBase.Delete("EmployeeId=" + Employee_ID.Text);
            }
            else
            {
                Message.Error("THIS ID IS NOT VALID SO THE DELETE CAN'T BE DONE");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (Employee_ID.Text != "" && First_Name.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("Employee Id=" + Employee_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("Employee Id = " + Employee_ID.Text, "First Name = '" + First_Name.Text + "'");
                }
            }
            else if (Employee_ID.Text != "" && Last_Name.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("Employee Id=" + Employee_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("Employee Id = " + Employee_ID.Text, "Rating = " + Last_Name.Text);
                }
            }
            else if (Employee_ID.Text != "" && Date_Of_Birth.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("Employee Id=" + Employee_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("Employee Id = " + Employee_ID.Text, "Date_Of_Birth = " + Date_Of_Birth.Text);
                }
            }
            
            else if(Employee_ID.Text != "" && Address.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("Employee Id=" + Employee_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("Employee Id = " + Employee_ID.Text, "Address = " + Address.Text);
                }
            }
            else if(Employee_ID.Text != "" && Job_Title.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("Employee Id=" + Employee_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("Employee Id = " + Employee_ID.Text, "Job Title = " + Job_Title.Text);
                }
            }
            else if(Employee_ID.Text != "" && Salary.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("Employee Id=" + Employee_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("Employee Id = " + Employee_ID.Text, "Salary = " + Salary.Text);
                }
            }
            else if(Employee_ID.Text != "" && Working_Hours.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("Employee Id=" + Employee_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("Employee Id = " + Employee_ID.Text, "Working Hours = " + Working_Hours.Text);
                }
            }
            else
            {
                Message.Error("UPDATE CANT BE DONE");
            }
            
        }
        List<string> Headers =new List<string>();
        void MakeCondition(ref string Condition, string Add)
        {
            if (Condition == "") Condition += Add;
            else Condition += " and " + Add;
        }
        private void Search_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string condition = "";
            if (Employee_ID.Text != "")
            {
                MakeCondition(ref condition, "EmployeeId =" + Employee_ID.Text );
            }
            if (First_Name.Text != "")
            {
                MakeCondition(ref condition, "FirstName ='" + First_Name.Text+"'");
            }
            if (Last_Name.Text != "")
            {
                MakeCondition(ref condition, "LastName=''" + Last_Name.Text + "'");
            }
            DateTime x = DateTime.Now;
            x = x.AddDays(1);
            if (Date_Of_Birth.Text!=x.ToLongDateString())
            {
                MakeCondition(ref condition, "LastName=''" + Last_Name.Text + "'");
            }
            if(Address.Text!="")
            {
                MakeCondition(ref condition, "Address=''" + Address.Text + "'");
            }
            if(Job_Title.Text!="")
            {
                MakeCondition(ref condition, "JobTitle=''" + Job_Title.Text + "'");
            }
            if(Working_Hours.Text!="")
            {
                MakeCondition(ref condition, "WorkingHours=''" + Working_Hours.Text + "'");
            }
            if(Salary.Text!="")
            {
                MakeCondition(ref condition, "Salary=''" + Salary.Text + "'");
            }
            Screen_hotel.DataSource = dataBase.GetTable(Headers, dataBase.Read(condition));
        }

        private void Employee_Load(object sender, EventArgs e)
        {
           

            DateTime x = DateTime.Now;
            x = x.AddDays(1);
            Date Now = new Date(x.ToLongDateString());
            Now.ToFormatedString();

            Date_Of_Birth.Text=x.ToLongDateString();
        }

        private void Screen_hotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

=======
            
>>>>>>> e6c447271193e5588610f34433b5994ba0cc7db6
        }
    }
}
