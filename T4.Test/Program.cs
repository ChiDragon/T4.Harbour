using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T4.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlDbHelper mysql = new MySqlDbHelper();
            List<DbTable> dbTable = mysql.GetDbTables();
        }
    }
}
