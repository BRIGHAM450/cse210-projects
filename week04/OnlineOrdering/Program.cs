using System;

class Program
{
    static void Main(string[] args)
    {
        // Address and Customer 1
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        // Order 1
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 1200, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25, 2));

        // Address and Customer 2
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Order 2
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P003", 800, 1));
        order2.AddProduct(new Product("Charger", "P004", 20, 3));
        order2.AddProduct(new Product("Headphones", "P005", 60, 1));

        // Display results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}\n");
    }
}
