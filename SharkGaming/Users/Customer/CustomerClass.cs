namespace SharkGaming.Users.Customer
{
    public class CustomerClass
    {
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Postcode { get; set; }
        public string Country { get; set; }

        public CustomerClass()
        {

        }

        public CustomerClass(int phone, string email, string address, int postcode, string country)
        {
            Phone = phone;
            Email = email;
            Address = address;
            Postcode = postcode;
            Country = country;

        }
    }
}
