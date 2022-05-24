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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        void PerformLogin()
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") Message.Error("Id is required");
            else
            {
                string Id = textBox1.Text;
                string Password = textBox2.Text;
                DataBase dataBase = new DataBase("Employee");
                if(dataBase.Read("EmployeeId = " + Id + " and Password = '"+Password+"'").Count > 0) PerformLogin();
                else
                {
                    Message.Error("Id or Password incorect");
                    textBox1.Text = String.Empty;
                    textBox2.Text = String.Empty;
                }
            }
        }
    }
}
