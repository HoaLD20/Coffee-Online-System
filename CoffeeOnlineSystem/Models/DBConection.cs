using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CoffeeOnlineSystem.Models
{
    public class DBConection
    {
        string conn;

        public DBConection()
        {
            conn = "Data Source=DESKTOP-G9K0HMN;Initial Catalog=COFFEE;Integrated Security=True";
        }

        public SqlConnection GetConnection()
        {

            return new SqlConnection(conn);
        }
    }
}