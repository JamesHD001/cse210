using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.\n");

        Address address1 = new Address(
            "12 Allen Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop", "P001", 800, 1);
        Product product2 = new Product("Mouse", "P002", 25, 2);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Address address2 = new Address(
            "15 Adeola Odeku",
            "Lagos",
            "Lagos",
            "Nigeria"
        );

        Customer customer2 = new Customer("Amina Bello", address2);

        Order order2 = new Order(customer2);

        Product product3 = new Product("Headphones", "P003", 50, 2);
        Product product4 = new Product("USB Cable", "P004", 10, 3);

        order2.AddProduct(product3);
        order2.AddProduct(product4);

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("PACKING LABEL:");
            Console.WriteLine("=================================");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("\nSHIPPING LABEL:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("=================================");
            Console.WriteLine($"\nTOTAL COST: ${order.CalculateTotal():F2}");
            Console.WriteLine("=================================\n");
        }
    }
}