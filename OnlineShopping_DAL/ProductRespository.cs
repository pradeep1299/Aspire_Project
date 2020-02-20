using OnlineShopping_Entity;
using System.Data;
using System.Data.SqlClient;

namespace OnlineShopping_DAL
{
    public class ProductRespository
    {
        SqlConnection connection = MySqlConnection.Myconnect();
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
        public int InsertProductDetails(ProductEntity product)
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
        public DataTable Refreshdata()
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
                    return data;
                }
            }
        }
    }
}
