using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project_Database
{
    internal class DataBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-82NJIQUH;Initial Catalog=Project Database;Integrated Security=True;");
        public string TableName;
        public DataBase(string TableName)
        {
            this.TableName = TableName;
        }
        /// <summary>
        /// Inserting Values in the table
        /// Data Must be formated well
        /// </summary>
        /// <param name="Data">
        /// Data Must be formated well
        /// Value1, Value2, ......
        /// if string then 'Value1' 
        /// </param>
        public void Insert(string Data)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into " + TableName + " Values(" + Data + ")");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        /// <summary>
        /// Gets the Data from the Table
        /// </summary>
        /// <param name="Condition">
        /// Condition Must be Fromated well
        ///      ColumnName Compare Value
        /// Like EmployeeName = 'George'
        /// </param>
        /// <returns>Returns the Data in List of Lists </returns>
        public List<List<string>> Read(string Condition = "")
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From " + TableName + ((Condition != "") ? " Where " + Condition : ""));
            cmd.Connection = con;
            SqlDataReader rdr = cmd.ExecuteReader();
            List<List<string>> Data = new List<List<string>>();
            while (rdr.Read())
            {
                List<string> DataList = new List<string>();
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    DataList.Add(rdr[i].ToString());
                }
                Data.Add(DataList);
            }
            con.Close();
            return Data;
        }
        /// <summary>
        /// Make DataTable for Printing From the information
        /// </summary>
        /// <param name="Headers">The Header of the Table</param>
        /// <param name="Data">the Info of the Table</param>
        /// <returns>The DataTable for Printing</returns>
        public DataTable GetTable(List<string> Headers, List<List<string>> Data)
        {
            DataTable Table = new DataTable();
            foreach (string item in Headers)
            {
                Table.Columns.Add(item);
            }
            for (int i = 0; i < Data.Count; i++)
            {
                Table.Rows.Add(Data[i].ToArray());
            }
            return Table;
        }
        /// <summary>
        /// Delete From the Table
        /// </summary>
        /// <param name="Condition">
        /// Condition Must be Fromated well
        /// ColumnName Compare Value
        /// Like EmployeeName = 'George'</param>
        public void Delete(string Condition)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete " + TableName + " Where " + Condition);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        /// <summary>
        /// Update thet Table 
        /// </summary>
        /// <param name="Condition">
        /// Condition Must be Fromated well
        /// ColumnName Compare Value
        /// Like EmployeeName = 'George'</param>
        /// <param name="Set">
        /// Set Must Be Formated Well
        /// ColumnName = Value, ColumnName = Value
        /// Like EmployeeName = 'George', Salary = 3000
        /// </param>
        ///
        public void Update(string Condition, string Set)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update " + TableName + " Set " + Set + " Where " + Condition);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
    class Date
    {
        public int Day;
        public int Month;
        public int Year;
        public Date() { }
        public Date(string Date)
        {
            string date = "";
            int c = 0;
            int pos = 0;
            int pos2 = 0;
            int pos3 = 0;
            for (int i = 0; i < Date.Length; i++)
            {
                if (Date[i] == ' ')
                {
                    c++;
                    if (c == 1) pos2 = i;
                    if (c == 2) pos = i;
                    if (c == 3) pos3 = i;
                }
            }
            pos++;
            for (int i = pos; i < Date.Length; i++)
            {
                if (Date[i] == ',') break;
                date += Date[i];
            }
            this.Day = int.Parse(date);
            date = "";
            if (Date.Contains("January")) date += "1";
            else if (Date.Contains("February")) date += "2";
            else if (Date.Contains("March")) date += "3";
            else if (Date.Contains("April")) date += "4";
            else if (Date.Contains("May")) date += "5";
            else if (Date.Contains("June")) date += "6";
            else if (Date.Contains("July")) date += "7";
            else if (Date.Contains("August")) date += "8";
            else if (Date.Contains("September")) date += "9";
            else if (Date.Contains("October")) date += "10";
            else if (Date.Contains("November")) date += "11";
            else if (Date.Contains("December")) date += "12";
            Month = int.Parse(date);
            date = "";
            for (int i = pos3 + 1; i < Date.Length; i++)
            {
                date += Date[i];
            }
            this.Year = int.Parse(date);
        }
        public static Date FromDataBase(string Date)
        {
            string[] temp = Date.Split("/");
            Date x = new Date();
            x.Day = int.Parse(temp[0]);
            x.Month = int.Parse(temp[1]);
            x.Year = int.Parse(temp[2]);
            return x;
        }
        public string ToString()
        {
            string Date = Day.ToString() + "/" + Month.ToString() + "/" + Year.ToString();
            return Date;
        }
        public static bool operator >(Date First, Date Second)
        {
            if(First.Year > Second.Year) return true;
            else if(First.Year == Second.Year)
            {
                if(First.Month > Second.Month) return true;
                else if(First.Month == Second.Month)
                {
                    if(First.Day > Second.Day) return true;
                }
            }
            return false;
        }
        public static bool operator <(Date First, Date Second)
        {
            if (First.Year < Second.Year) return true;
            else if (First.Year == Second.Year)
            {
                if (First.Month < Second.Month) return true;
                else if (First.Month == Second.Month)
                {
                    if (First.Day < Second.Day) return true;
                }
            }
            return false;
        }
    }
}
