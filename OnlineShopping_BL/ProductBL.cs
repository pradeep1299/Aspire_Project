using System.Data;
using OnlineShopping_DAL;
using OnlineShopping_Entity;

namespace OnlineShopping_BL
{
    public class ProductBL
    {
        ProductRespository productRespository;

        public ProductBL()
        {
            productRespository = new ProductRespository();
        }
        public int AddProduct(ProductDetails product)
        {
            return productRespository.InsertProductDetails(product);
        }
        public void UpdateProduct(int id, string name, int stock, int category, double price)
        {
            productRespository.UpdateProductDetails(id, name, stock, category, price);
        }
        public void DeleteProduct(int id)
        {
            productRespository.DeleteProductDetails(id);
        }
        public DataTable RefreshData()
        {
            return productRespository.Refreshdata();
        }
    }
}
