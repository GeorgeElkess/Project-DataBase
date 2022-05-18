﻿using System;
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
    public partial class Country : Form
    {
        public Country()
        {
            InitializeComponent();
        }

        private void COUNTRY_RATE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar)) e.Handled = true;

        }
        DataBase dataBase = new DataBase("Country");
        
        private void ADD_Click(object sender, EventArgs e)
        {
            
            if(COUNTRY_NAME.Text!=""&&COUNTRY_RATE.Text!="")
            {
                List<List<string>> Datachec;
                Datachec = dataBase.Read("COUNTRY_NAME");
                if ()
                {
                    dataBase.Insert(COUNTRY_NAME.Text + ", " + COUNTRY_RATE.Text);
                }
                
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
    }
}
