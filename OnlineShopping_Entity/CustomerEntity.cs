
namespace OnlineShopping_Entity
{
    public class CustomerEntity
    {
        //public enum Gender
        //{
        //    Male,
        //    Female
        //}
        //public enum Category
        //{
        //    Mobile_Phones,
        //    Fashion,
        //    Toys,
        //    Fitness,
        //    Electronics
        //}
        public string customerName
        {
            get;
            set;
        }
        public long customerMobile
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
        //public Gender gender
        //{
        //    get;
        //    set;
        //}
        //public Category category
        //{
        //    get;
        //    set;
        //}
        public CustomerEntity(string name,long mobile,string email,string password)
        {
            this.customerName = name;
            this.customerMobile = mobile;
            this.customerEMail = email;
            this.customerPassword = password;
        }
    }
}
