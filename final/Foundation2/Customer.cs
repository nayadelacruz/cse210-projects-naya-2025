using System;
class Customer
{
    private string _customerName;
    private Address _customerAddress;
    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _customerAddress = address;
    }
    public bool LivesInUSA()
    {
        return _customerAddress.IsInUSA();
    }
    public string GetCustomerName()
    {
        return _customerName;
    }
    public Address GetCustomerAddress()
    {
        return _customerAddress;
    }
}