using System;

class Address
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

    public bool IsInUSA()
    {
        return Country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{Street}\n{City}, {StateProvince}\n{Country}";
    }
}
