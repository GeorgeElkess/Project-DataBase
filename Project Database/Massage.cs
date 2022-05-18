using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Database
{
    internal class Massage
    {
        private Massage() { }
        static void Error(string Massege)
        {
            MessageBox.Show(Massege,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        /// <summary>
        /// Inform the User
        /// </summary>
        /// <param name="Massege"></param>
        /// <returns> true if user press Ok false if user press Cancel</returns>
        static bool Inform(string Massege)
        {
            DialogResult a = MessageBox.Show(Massege,"Inform",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (a.ToString() != "OK") return false;
            else return true;
        }
    }
}
