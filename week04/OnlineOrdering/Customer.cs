public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string Info()
    {
        string info = _name;
        return info;
    }

    public string Location()
    {
        string location = _address.GetFullAddress();
        return location;
    }
    public bool IsInUSA()
    {
        Address address = _address;
        bool address1 = address.IsInUSA();
        return address1;
    }
}