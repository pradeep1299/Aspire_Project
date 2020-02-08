using System;
using OnlineShoppingReference;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineShoppingWeb
{
    public partial class ProductList : System.Web.UI.Page
    {
        CreateAccountReference create = new CreateAccountReference();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }
        protected void BindData()
        {
            create.Refreshdata(ProductTable);
        }
        protected void ProductTable_ListUpdate(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(ProductTable.DataKeys[e.RowIndex].Values["ProductId"].ToString());
            string name = (ProductTable.Rows[e.RowIndex].FindControl("txtProductNameEdit") as TextBox).Text;
            int category = Convert.ToInt32((ProductTable.Rows[e.RowIndex].FindControl("txtCategoryIDEdit") as TextBox).Text);
            int price = Convert.ToInt32((ProductTable.Rows[e.RowIndex].FindControl("txtPriceEdit") as TextBox).Text);
            int stock = Convert.ToInt32((ProductTable.Rows[e.RowIndex].FindControl("txtStocksEdit") as TextBox).Text);
            create.UpdateProductDetails(id, name, stock, category, price);
            ProductTable.EditIndex = -1;
            BindData();
        }
        protected void ProductTable_ListDelete(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(ProductTable.DataKeys[e.RowIndex].Values["ProductId"].ToString());
            create.DeleteProductDetails(id);
            BindData();
        }
        protected void ProductTable_ListEdit(object sender, GridViewEditEventArgs e)
        {
            ProductTable.EditIndex = e.NewEditIndex;
            BindData();
        }
        protected void ProductTable_ListCancelEdit(object sender, GridViewCancelEditEventArgs e)
        {
            ProductTable.EditIndex = -1;
            BindData();
        }
        protected void Insert_Click(object sender, EventArgs e)
        {
            string name = (ProductTable.FooterRow.FindControl("txtProductName") as TextBox).Text;
            int categoryId = Convert.ToInt32((ProductTable.FooterRow.FindControl("txtCategoryID") as TextBox).Text);
            double price = Convert.ToDouble((ProductTable.FooterRow.FindControl("txtPrice") as TextBox).Text);
            int stock = Convert.ToInt32((ProductTable.FooterRow.FindControl("txtStocks") as TextBox).Text);
            ProductDetails product = new ProductDetails(name,stock,categoryId,price);
            int row = create.InsertProductDetails(product);
            ProductTable.EditIndex = -1;
            BindData();
        }
    }
}