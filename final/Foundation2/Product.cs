using System;
class Product
{
    private string _productName;
    private int _productID;
    private decimal _pricePerUnit;
    private int _quantity;
    public Product(string productName, int productID, decimal pricePerUnit, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }
    public string GetProductName()
    {
        return _productName;
    }
    public int GetProductID()
    {
        return _productID;
    }
    public decimal GetPricePerUnit()
    {
        return _pricePerUnit;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public decimal GetTotalPrice()
    {
        return _pricePerUnit * _quantity;
    }
}    