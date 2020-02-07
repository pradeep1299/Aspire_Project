using System;
using OnlineShoppingReference;

namespace OnlineShoppingWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Signup_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignupPage.aspx");
        }
        protected void Login_Click(object sender, EventArgs e)
        {
            string user = Username.Text;
            string pass = Password.Text;
            CreateAccountReference create = new CreateAccountReference();
            int row = create.LoginDetails(user,pass);
            if (row >= 1)
            {
                Response.Write("<script language='javascript'>window.alert('Login Successfully');window.location='yourpage.aspx';</script>");
                Response.Redirect("GridPage.aspx");
            }
            else
            {
                Response.Write("<script language='javascript'>window.alert('Try Again Login not Successfully');window.location='LoginPage.aspx';</script>");
            }
        }
    }
}