using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Database
{
    internal class Message
    {
        private Message() { }
        public static void Error(string Message)
        {
            MessageBox.Show(Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        /// <summary>
        /// Inform the User
        /// </summary>
        /// <param name="Massege"></param>
        /// <returns> true if user press Ok false if user press Cancel</returns>
        static bool Inform(string Message)
        {
            DialogResult a = MessageBox.Show(Message,"Inform",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (a.ToString() != "OK") return false;
            else return true;
        }
    }
}
