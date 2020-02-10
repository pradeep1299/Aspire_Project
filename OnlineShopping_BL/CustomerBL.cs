using System.Data;
using OnlineShopping_DAL;
using OnlineShopping_Entity;

namespace OnlineShopping_BL
{
    public class CustomerBL
    {
        CustomerRespository customerRespository;
        public CustomerBL()
        {
            customerRespository = new CustomerRespository();
        }
        public int AddCustomer(CustomerDetails Customer)
        {
            return customerRespository.CreateAccount(Customer);
        }
        public int LoginDetails(string username, string password)
        {
            return customerRespository.LoginDetails(username, password);
        }
    }
}
