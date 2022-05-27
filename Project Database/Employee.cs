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
        void Initialize()
        {
            Employee_ID.Text = String.Empty;
            First_Name.Text = String.Empty;
            Last_Name.Text = String.Empty;
            DateTime t = DateTime.Now;
            t = t.AddDays(1);
            Date_Of_Birth.Text = t.ToLongDateString();
            Job_Title.Text = String.Empty;
            Address.Text = String.Empty;
            Salary.Text = String.Empty;
            Working_Hours.Text = String.Empty;
            Password.Text = String.Empty;
        }
        DataBase dataBase = new DataBase("Employee");
        private void Add_Click(object sender, EventArgs e)
        {
            if (First_Name.Text != "" && Last_Name.Text != "" && Date_Of_Birth.Text != ""
                && Address.Text != "" && Job_Title.Text != "" && Salary.Text != "" && Working_Hours.Text != "" &&Password.Text!="")
            {
                List<List<string>> datachec = new List<List<string>>();
                datachec = dataBase.Read("FirstName= '" + First_Name.Text + "'");
                if (datachec.Count == 0)
                {
                    Date date = new Date(Date_Of_Birth.Text);
                    dataBase.Insert("'" + First_Name.Text + "', '" + Last_Name.Text + "', '" + date.ToFormatedString() + "', '" +
                        Address.Text + "', '" + Job_Title.Text + "', " + Salary.Text + ", '" + Working_Hours.Text + "', '"+ Password.Text + "'");
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
            if (Employee_ID.Text != "")
            {
                dataBase.Delete("EmployeeId=" + Employee_ID.Text);
                Initialize();
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
                Datachec = dataBase.Read("EmployeeId=" + Employee_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("EmployeeId = " + Employee_ID.Text, "FirstName = '" + First_Name.Text + "'");
                }
            }
            if (Employee_ID.Text != "" && Last_Name.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("EmployeeId=" + Employee_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("EmployeeId = " + Employee_ID.Text, "LastName = '" + Last_Name.Text + "'");
                }
            }
            DateTime t = DateTime.Now;
            t = t.AddDays(1);
            if (Employee_ID.Text != "" && Date_Of_Birth.Text != t.ToLongDateString())
            {
                Date date = new Date(Date_Of_Birth.Text);
                List<List<string>> Datachec;
                Datachec = dataBase.Read("EmployeeId=" + Employee_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("EmployeeId = " + Employee_ID.Text, "DateOfBirth = '" + date.ToFormatedString() + "'");
                }
            }

            if (Employee_ID.Text != "" && Address.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("EmployeeId=" + Employee_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("EmployeeId = " + Employee_ID.Text, "Address = '" + Address.Text + "'");
                }
            }
            if (Employee_ID.Text != "" && Job_Title.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("EmployeeId=" + Employee_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("EmployeeId = " + Employee_ID.Text, "JobTitle = '" + Job_Title.Text + "'");
                }
            }
            if (Employee_ID.Text != "" && Salary.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("EmployeeId=" + Employee_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("EmployeeId = " + Employee_ID.Text, "Salary = " + Salary.Text);
                }
            }
            if (Employee_ID.Text != "" && Working_Hours.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("EmployeeId=" + Employee_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("EmployeeId = " + Employee_ID.Text, "WorkingHours = '" + Working_Hours.Text + "'");
                }
            }
            if(Employee_ID.Text != "" && Password.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("EmployeeId=" + Employee_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("EmployeeId = " + Employee_ID.Text, "Password = '" + Password.Text + "'");
                }
            }
            Initialize();
        }
        List<string> Headers = new List<string>();
        void MakeCondition(ref string Condition, string Add)
        {
            if (Condition == "") Condition += Add;
            else Condition += " and " + Add;
        }
        private void Search_Click(object sender, EventArgs e)
        {
            string condition = "";
            if (Employee_ID.Text != "")
            {
                MakeCondition(ref condition, "EmployeeId =" + Employee_ID.Text);
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
            if (Job_Title.Text != "")
            {
                MakeCondition(ref condition, "JobTitle='" + Job_Title.Text + "'");
            }
            if (Working_Hours.Text != "")
            {
                MakeCondition(ref condition, "WorkingHours='" + Working_Hours.Text + "'");
            }
            if (Salary.Text != "")
            {
                MakeCondition(ref condition, "Salary=" + Salary.Text);
            }
            List<List<string>> x = dataBase.Read(condition);
            for (int i = 0; i < x.Count; i++)
            {
                x[i].RemoveAt(x[i].Count - 1);
            }
            Screen_hotel.DataSource = dataBase.GetTable(Headers,x);
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            Headers.Add("Employee Id");
            Headers.Add("First Name");
            Headers.Add("Last Name");
            Headers.Add("Date of Birth");
            Headers.Add("Address");
            Headers.Add("Job Title");
            Headers.Add("Salary");
            Headers.Add("Working Hours");
            Initialize();
        }

        private void Screen_hotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
