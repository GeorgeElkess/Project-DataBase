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
            int t = 1;
            for (int i = 0; i <= 30; i++)
            {
                Day.Items.Add(i.ToString("t"));
                t++;
            }
        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            int r = 1;
            for (int i = 0; i < 13; i++)
            {
                Month.Items.Add(i.ToString("r"));
                r++;
            }
        }

        private void Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            int w = 1900;
            for (int i = 0; i < 1100; i++)
            {
                Year.Items.Add(i.ToString("w"));
                w++;
            }
        }

        private void Sex_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Sex.CheckedItems.ToString();
           ///fy hena so2al?????????
        }

        private void ADD_Click(object sender, EventArgs e)
        {

        }
    }
}
