public class Address
{
    public string Street;
    public string City;
    public string StateOrProvince;
    public string Country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        Street = street;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country.Equals("USA", StringComparison.OrdinalIgnoreCase)
            || Country.Equals("United States", StringComparison.OrdinalIgnoreCase);
    }

    public string FullAddress()
    {
        return $"{Street}\n{City}, {StateOrProvince}\n{Country}";
    }
}
