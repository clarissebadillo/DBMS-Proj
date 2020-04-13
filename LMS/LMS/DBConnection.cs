using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    class DBConnection
    {
        public string MyConnection()
        {
            string con = "Data Source=LAPTOP-PM36MAJR;Initial Catalog=LibraryDB;Integrated Security=True";
            return con;
        }

    }
}
