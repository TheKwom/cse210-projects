using System;

class Program
{
    static void Main()
    {
        // Create two customers
        Address usaAddress = new Address("W State Street", "Eagle", "ID", "USA");
        Address nonUsaAddress = new Address("12 W Street", "Chalco", "Mexico City", "Mexico");

        Customer customer1 = new Customer("Mike Davis", usaAddress);
        Customer customer2 = new Customer("Tyler J", nonUsaAddress);

        // Create products
        Product product1 = new Product("Cat Litter", "C1", 40.0, 2);
        Product product2 = new Product("Cat Water Bowl", "C2", 12.0, 1);
        Product product3 = new Product("Xbox", "G12", 300.0, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.CalculateTotalPrice());

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.CalculateTotalPrice());
    }
}