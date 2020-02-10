using System;
using OnlineShopping_Entity;
using OnlineShopping_Common;
using OnlineShopping_BL;

namespace OnlineShoppingWeb
{
    public partial class SignupPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Registration_Click(object sender, EventArgs e)
        {
            string customerName = name.Text;
            string mobileNo = mobile.Text;
            string emailId = email.Text;
            string password = repassword.Text;

            CustomerBL create = new CustomerBL();
            CustomerDetails get = new CustomerDetails(customerName, mobileNo, emailId, password);
            int row = create.AddCustomer(get);
            if (row >= 1)
            {
                Response.Write("<script language='javascript'>window.alert('Registration Successfully');window.location='LoginPage.aspx';</script>");
            }
            else
            {
                Response.Write("<script language='javascript'>window.alert('Try Again Registration not Successfully');window.location='SignupPage.aspx';</script>");
            }
        }
    }
}