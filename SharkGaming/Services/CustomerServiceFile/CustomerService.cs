using SharkGaming.MockData;
using SharkGaming.Services.JsonServiceFile;
using SharkGaming.Users.Customer;

namespace SharkGaming.Services.CustomerServiceFile
{
    public class CustomerService
    {
        public List<CustomerClass> _customerClass { get; set; }

        private JsonService JsonService { get; set; }

        public CustomerService()
        {
            _customerClass = MockCustomer.GetMockCustomer();
        }


        public CustomerService(JsonService jsonService)
        {
            JsonService = jsonService;

            _customerClass = MockCustomer.GetMockCustomer();
            //_customerClass = jsonService.GetJsonCustomer().ToList();
            //JsonService.SaveJsonCustomer(_customerClass);
        }

        public void AddCustomer(CustomerClass customerClass)
        {
            _customerClass.Add(customerClass);
            JsonService.SaveJsonCustomer(_customerClass);
        }

    }
}
