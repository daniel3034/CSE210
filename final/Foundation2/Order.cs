using System;
using System.Collections.Generic;

class Order
{
    private Customer Customer { get; }
    private List<Product> Products { get; }

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.GetTotalCost();
        }
        total += Customer.IsInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in Products)
        {
            label += product.GetProductInfo() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{Customer.GetName()}\n{Customer.GetAddress()}";
    }
}
