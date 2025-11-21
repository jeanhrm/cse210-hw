using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Order 1: Local Huancavelica crafts -----
        Address hvAddress = new Address(
            "Jr. Plaza de Armas 120",
            "Huancavelica",
            "Huancavelica",
            "Peru");

        Customer hvCustomer = new Customer("Rosa Huamán – Andean Textiles", hvAddress);

        Order order1 = new Order(hvCustomer);
        order1.AddProduct(new Product("Andean Loom Woven Scarf", "SCF-HV-001", 45.00m, 2));
        order1.AddProduct(new Product("Traditional Huancavelica Hat", "HAT-HV-010", 35.50m, 1));
        order1.AddProduct(new Product("Handmade Alpaca Mittens", "MIT-HV-021", 25.75m, 3));

        //Order 2: International customer interested in Huancavelica products -----
        Address usaAddress = new Address(
            "742 Evergreen Terrace",
            "Springfield",
            "Oregon",
            "USA");

        Customer usaCustomer = new Customer("Michael Johnson – Cultural Collector", usaAddress);

        Order order2 = new Order(usaCustomer);
        order2.AddProduct(new Product("Ceramic Piece from Yauli", "CER-HV-050", 60.00m, 1));
        order2.AddProduct(new Product("Choclococha Lake Photo Print", "PHO-HV-075", 30.00m, 2));

        //Store orders in a list to iterate easily
        List<Order> orders = new List<Order> { order1, order2 };

        //Display information for each order -----
        int orderNumber = 1;
        foreach (Order order in orders)
        {
            Console.WriteLine("============================================");
            Console.WriteLine($"Order #{orderNumber}");

            Console.WriteLine();
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine(order.GetPackingLabel());

            decimal totalCost = order.GetTotalCost();
            Console.WriteLine($"Total Cost: ${totalCost:F2}");

            orderNumber++;
            Console.WriteLine();
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
