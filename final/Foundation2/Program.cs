using System;

class Program
{
    static void Main(string[] args)
    {
        //Order 1
        Console.WriteLine("Order 1:");
        Address address1 = new Address("11208 SW 187th Ave", "Seattle", "WA", "USA");
        Customer customer1 = new Customer("Naya Aguilar", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("Shoes", 12303, 32.50m, 1);
        Product product2 = new Product("Socks", 12304, 5.50m, 3);
        order1.AddProduct(product1);
        order1.AddProduct(product2);    
        Console.WriteLine(order1.GetPackagingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");
        //Order 2
        Console.WriteLine();
        Console.WriteLine("Order 2:");
        Address address2 = new Address("Hidalgo 308", "Costa Bonita", "Guatemala", "Guatemala");
        Customer customer2 = new Customer("Rosa Jimenez", address2);
        Order order2 = new Order(customer2);
        Product product3 = new Product("T-shirts", 12305, 10.00m, 2);
        Product product4 = new Product("Jeans", 12306, 30.00m, 1);
        Product product5 = new Product("Jacket", 12307, 60.00m, 1);
        order2.AddProduct(product3);
        order2.AddProduct(product4);  
        order2.AddProduct(product5);  
        Console.WriteLine(order2.GetPackagingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}