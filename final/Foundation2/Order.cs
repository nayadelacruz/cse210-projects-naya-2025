using System;
class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public decimal GetTotalPrice()
    {
        bool isInUSA = _customer.LivesInUSA();
        decimal total = 0;
        decimal shippingCost = 0;

        if (isInUSA)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        foreach (Product product in _products)
        {
            total += product.GetTotalPrice();
        }
        total += shippingCost;

            return total;
    }
    public string GetPackagingLabel()
    {
        string label = "Packaging Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetProductName()} (ID: {product.GetProductID()}) \n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        string label = "Shipping Label: \n";
        label += $"{_customer.GetCustomerName()} \n{_customer.GetCustomerAddress().GetFullAddress()}";
        return label;
    }    
}