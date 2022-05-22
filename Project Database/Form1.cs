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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Country country = new Country();
            this.Hide();
            country.ShowDialog();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            this.Hide();
            employee.ShowDialog();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Hotell hotell = new Hotell();
            this.Hide();
            hotell.ShowDialog();
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Place place = new Place();
            this.Hide();
            place.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Trip trip = new Trip();
            this.Hide();
            trip.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Visit visit = new Visit();
            this.Hide();
            visit.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Categorie Categorie = new Categorie();
            this.Hide();
            Categorie.ShowDialog();
            this.Close();
        }
    }
}