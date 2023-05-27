using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Address usaAddress = new Address("50 North W Temple Street", "Salt Lake City", "UT", "USA");
        Address canadaAddress = new Address("10060 Bramalea Rd", "Brampton", "ON", "Canada");

        Customer customer1 = new Customer("Joseph Smith", usaAddress);
        Customer customer2 = new Customer("Emma Smith", canadaAddress);

        Product product1 = new Product("Product 1", 1, 15.5m, 20);
        Product product2 = new Product("Product 2", 2, 55m, 5);
        Product product3 = new Product("Product 3", 3, 8.25m, 11);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());

        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
    }
}