
namespace OnlineShopping_Entity
{
    public class CustomerDetails
    {
        public string customerName
        {
            get;
            set;
        }
        public string customerMobile
        {
            get;
            set;
        }
        public string customerPassword
        {
            get;
            set;
        }
        public string customerEMail
        {
            get;
            set;
        }
        public CustomerDetails(string name,string mobile,string email,string password)
        {
            this.customerName = name;
            this.customerMobile = mobile;
            this.customerEMail = email;
            this.customerPassword = password;
        }
    }
}
