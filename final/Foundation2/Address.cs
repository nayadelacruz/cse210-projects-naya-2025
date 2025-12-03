using System;
class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private bool _isInUSA;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetStreet()
    {
        return _street;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetCountry()
    {
        return _country;
    }
public bool IsInUSA()
    {
        _isInUSA = false; 
        if (_country == "USA" || _country == "United States" || _country == "United States of America")
        {
            _isInUSA = true;
        }
        return _isInUSA;

    }

    public string GetFullAddress()
    {
        string fullAddress = $"{_street}\n{_city}, {_state}, {_country}";
        return fullAddress;
    }  
}