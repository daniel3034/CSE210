namespace EventPlanning
{
    public class Address
    {
        private string Street { get; }
        private string City { get; }
        private string StateProvince { get; }
        private string Country { get; }

        public Address(string street, string city, string stateProvince, string country)
        {
            Street = street;
            City = city;
            StateProvince = stateProvince;
            Country = country;
        }

        public string GetFullAddress()
        {
            return $"{Street}, {City}, {StateProvince}, {Country}";
        }
    }
}
