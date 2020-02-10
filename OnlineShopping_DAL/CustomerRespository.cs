using OnlineShopping_Entity;
using System.Data;
using System.Data.SqlClient;


namespace OnlineShopping_DAL
{
    public class CustomerRespository
    {
        SqlConnection connection = MySqlConnection.Myconnect();
        public int CreateAccount(CustomerDetails Customer)
        {
            using (SqlCommand command = new SqlCommand("spInsertUser", connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", Customer.customerName);
                command.Parameters.AddWithValue("@Mobile", Customer.customerMobile);
                command.Parameters.AddWithValue("@EmailId", Customer.customerEMail);
                command.Parameters.AddWithValue("@Password", Customer.customerPassword);
                int row = command.ExecuteNonQuery();
                command.Dispose();
                return row;
            }
        }
        public int LoginDetails(string username, string password)
        {
            using (SqlCommand command = new SqlCommand("spInsertLoginDetails", connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                int row = command.ExecuteNonQuery();
                command.Dispose();
                return row;
            }

        }
    }
}
