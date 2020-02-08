using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

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
                command.CommandType = CommandType.StoredProcedure;
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
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                int row = command.ExecuteNonQuery();
                command.Dispose();
                return row;
            }

        }
        public void UpdateProductDetails(int id, string name, int stock, int category, double price)
        {
            using (SqlCommand command = new SqlCommand("spProductDetailsUpdate", connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Stock", stock);
                command.Parameters.AddWithValue("@Category", category);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                command.Dispose();
            }
        }
        public void DeleteProductDetails(int id)
        {
            using (SqlCommand command = new SqlCommand("spProductDetailsDelete", connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Productid", id);
                command.ExecuteNonQuery();
            }

        }
        public int InsertProductDetails(ProductDetails product)
        {
            using (SqlCommand command = new SqlCommand("spProductDetailsInsert", connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", product.productName);
                command.Parameters.AddWithValue("@Stock", product.productStock);
                command.Parameters.AddWithValue("@Category", product.productCategoryId);
                command.Parameters.AddWithValue("@Price", product.productPrice);
                int row = command.ExecuteNonQuery();
                command.Dispose();
                return row;
            }
        }
        public void Refreshdata(GridView ProductTable)
        {
            using (SqlCommand command = new SqlCommand("spProductDetails", connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                adapter.SelectCommand = command;
                using (DataTable data = new DataTable())
                {
                    adapter.Fill(data);
                    ProductTable.DataSource = data;
                    ProductTable.DataBind();
                }
            } 
        }
    }
}
