public class Address
{
    protected string _address;
    protected string _country;
    protected bool _isUsa;
    public Address(string address, string country)
    {
        _address = address;
        _country = country;
    }
    public bool inUsa()
    {
        return true;
    }
    public string getAddress()
    {
        return $" Address : {_address} country {_country}";
    }
    public string getCountry()
    {
        return _country ;
    }
}