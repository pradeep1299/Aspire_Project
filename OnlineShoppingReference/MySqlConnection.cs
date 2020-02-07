using System;
using System.Data.SqlClient;
using System.Configuration;

namespace OnlineShoppingReference
{
    class MySqlConnection
    {
        public static SqlConnection Myconnect()
        {
            string connect = ConfigurationManager.ConnectionStrings["OnlineShop"].ConnectionString;
            SqlConnection Connection = new SqlConnection(connect);
            return Connection;
        } 
    }
}
