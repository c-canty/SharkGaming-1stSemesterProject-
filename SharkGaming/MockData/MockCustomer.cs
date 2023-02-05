using SharkGaming.Users.Customer;

namespace SharkGaming.MockData
{
    public class MockCustomer
    {

        public static List<CustomerClass> customerClasses = new List<CustomerClass>()
        {
            //new CustomerClass("61675837", "hifnh@live.dk", "kærvej 12a", 4000, "Danmark"),
            //new CustomerClass("51528341", "christian_canty@hotmail.co.uk", "standgade 1 TV", 4300, "Danmark"),
            //new CustomerClass("42216198", "phulip.nielsen@gmail.com", "tranehusene 44", 2620, "Denmark")

            new CustomerClass(61675837, "hifnh@live.dk", "kærvej 12a", 4000, "Danmark"),
            new CustomerClass(51528341, "christian_canty@hotmail.co.uk", "standgade 1 TV", 4300, "Danmark"),
            new CustomerClass(42216198, "phulip.nielsen@gmail.com", "tranehusene 44", 2620, "Denmark")
        };

        public static List<CustomerClass> GetMockCustomer()
        {
            return customerClasses;
        }


    }
}
