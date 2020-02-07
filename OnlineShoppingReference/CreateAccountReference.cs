using System.Configuration;
using System.Data.SqlClient;

namespace OnlineShoppingReference
{
    public class CreateAccountReference
    {
        SqlConnection connection = MySqlConnection.Myconnect();
        public int CreateAccount(CustomerDetails customer)
        {
            using (SqlCommand command = new SqlCommand("spInsertUser", connection))
            {
                connection.Open();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", customer.customerName);
                command.Parameters.AddWithValue("@Mobile", customer.customerMobile);
                command.Parameters.AddWithValue("@EmailId", customer.customerEMail);
                command.Parameters.AddWithValue("@Password", customer.customerPassword);
                int row = command.ExecuteNonQuery();
                command.Dispose();
                return row;
            }
        }
        public int LoginDetails(string username, string password)
        {
            using(SqlCommand command = new SqlCommand("spInsertLoginDetails", connection))
            {
                connection.Open();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                int row = command.ExecuteNonQuery();
                command.Dispose();
                return row;
            }
        }
    }
}
