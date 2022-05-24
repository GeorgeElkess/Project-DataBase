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
            int r = 1;
            for(int i=0;i<13;i++)
            {
                Month.Items.Add(i.ToString("r"));
                r++;
            }
        }

        private void Year_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        DataBase dataBase = new DataBase("Employee");
        private void Add_Click(object sender, EventArgs e)
        {
            if(First_Name.Text!=""&&Last_Name.Text!=""&&Day.Text!=""&&Month.Text!=""&&Year.Text!=""
                &&Address.Text!=""&&Job_Title.Text!=""&&Salary.Text!=""&&Working_Hours.Text!="")
            {
                List<List<string>> datachec = new List<List<string>>();
                datachec = dataBase.Read("First Name= '" + First_Name.Text + "'");
                if(datachec.Count == 0)
            {
                    dataBase.Insert("'" + First_Name.Text + "', " + Last_Name.Text + "', " + Day.Text + "', " + Month.Text + "', " + Year.Text + "', " +
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
            else if (Employee_ID.Text != "" && Day.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("Employee Id=" + Employee_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("Employee Id = " + Employee_ID.Text, "Day = " + Day.Text);
                }
            }
            else if (Employee_ID.Text != "" && Month.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("Employee Id=" + Employee_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("Employee Id = " + Employee_ID.Text, "Month = " + Month.Text);
                }
            }
            else if(Employee_ID.Text != "" && Year.Text != "")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("Employee Id=" + Employee_ID.Text);
                if (Datachec.Count != 0)
                {
                    dataBase.Update("Employee Id = " + Employee_ID.Text, "Year = " + Year.Text);
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

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            int t = 1;
            for (int i = 0; i <= 30; i++)
            {
                Day.Items.Add(t.ToString());
                t++;
            }

            int w = 1900;
            for (int i = 0; i < 1100; i++)
            {
                Year.Items.Add(w.ToString());
                w++;
            }
        }
    }
}
