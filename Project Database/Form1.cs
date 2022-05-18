using System.Data;

namespace Project_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataBase DataBase = new DataBase("Employee");
        int c = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            DataBase.Insert("'George','Elkomos','27/9/2002','Shobra','Student',8," + c );
            c++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> Headrs = new List<string>();
            Headrs.Add("Id");     //      0
            Headrs.Add("First Name");//   1
            Headrs.Add("Last Name");//    2
            Headrs.Add("Date of Birth");//3
            Headrs.Add("Address");//      4
            Headrs.Add("Job Title");//    5
            Headrs.Add("Working Hours");//6
            Headrs.Add("Salary");//       7
            dataGridView1.DataSource = DataBase.GetTable(Headrs, DataBase.Read());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Id = textBox1.Text;
            DataBase.Delete("EmployeeId = " + Id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Id = textBox1.Text;
            List<List<string>> Data = DataBase.Read("EmployeeId = " + Id);
            float Salary = float.Parse(Data[0][7]);
            Salary += 1000;
            float WorkingHours = float.Parse(Data[1][6]);
            WorkingHours++;
            string Condition = "EmployeeId = " + Id;
            string Set = "Salary = " + Salary + ", " + "WorkingHours = " + WorkingHours;
            DataBase.Update(Condition, Set);
        }
    }
}