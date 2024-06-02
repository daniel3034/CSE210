using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        var customer1 = new Customer("John Doe", address1);
        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "123-ABC", 999.99m, 1)); // The m at the end of the prices refers to decimals so the code can treat these numbers as a decimals.
        order1.AddProduct(new Product("Mouse", "456-DEF", 49.99m, 2)); // The m at the end of the prices refers to decimals so the code can treat these numbers as a decimals.

        var address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");
        var customer2 = new Customer("Jane Smith", address2);
        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Desk Chair", "789-GHI", 149.99m, 1)); // The m at the end of the prices refers to decimals so the code can treat these numbers as a decimals.
        order2.AddProduct(new Product("Desk Lamp", "012-JKL", 29.99m, 3)); // The m at the end of the prices refers to decimals so the code can treat these numbers as a decimals.

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost()}\n");
        }
    }
}
