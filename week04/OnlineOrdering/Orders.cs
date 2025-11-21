using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal productsTotal = 0m;

        foreach (Product product in _products)
        {
            productsTotal += product.GetTotalPrice();
        }

        decimal shippingCost = _customer.GetAddress().IsInUSA() ? 5m : 35m;

        return productsTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder labelBuilder = new StringBuilder();
        labelBuilder.AppendLine("Packing Label:");

        foreach (Product product in _products)
        {
            labelBuilder.AppendLine($"- {product.GetName()} (ID: {product.GetProductId()})");
        }

        return labelBuilder.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder labelBuilder = new StringBuilder();
        labelBuilder.AppendLine("Shipping Label:");
        labelBuilder.AppendLine(_customer.GetName());
        labelBuilder.AppendLine(_customer.GetAddress().GetFullAddress());

        return labelBuilder.ToString();
    }
}
