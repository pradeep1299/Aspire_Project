using System;
using System.Configuration;
using System.Data.SqlClient;

namespace OnlineShopping_DAL
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
