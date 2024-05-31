using System;

class Program
{
    static void Main(string[] args)
    {
        // Products for US client
        Product usProduct1 = new Product("Laptop", "P001", 999.99f, 1);
        Product usProduct2 = new Product("Mouse", "P002", 49.99f, 2);
        List<Product> usProducts = new List<Product> { usProduct1, usProduct2 };

        // Products for Canadá client
        Product caProduct1 = new Product("Monitor", "M001", 199.99f, 1);
        Product caProduct2 = new Product("Keyboard", "K001", 79.99f, 1);
        List<Product> caProducts = new List<Product> { caProduct1, caProduct2 };

        // Products for Mexico client
        Product mxProduct1 = new Product("Tablet", "T001", 299.99f, 1);
        Product mxProduct2 = new Product("Stylus", "S001", 29.99f, 3);
        List<Product> mxProducts = new List<Product> { mxProduct1, mxProduct2 };

        // Order 1: Client in United States
        Address address1 = new Address("123 Main St", "Springfield", "IL", "United States");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(usProducts, customer1);

        Console.WriteLine($"\nOrder #1 Total Cost: {order1.CalculateTotalCost()}");
        Console.WriteLine("Packing Label:");
        Console.WriteLine("===========================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine("===========================");
        Console.WriteLine(customer1.GetFullAddress());

        // Order 2: Client in Canadá
        Address address2 = new Address("456 Maple St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(caProducts, customer2);

        Console.WriteLine($"\nOrder #2 Total Cost: {order2.CalculateTotalCost()}");
        Console.WriteLine("Packing Label:");
        Console.WriteLine("===========================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine("===========================");
        Console.WriteLine(customer2.GetFullAddress());

        // Order 3: Client in México
        Address address3 = new Address("789 Av. Reforma", "Ciudad de México", "CDMX", "Mexico");
        Customer customer3 = new Customer("Carlos Rivera", address3);
        Order order3 = new Order(mxProducts, customer3);

        Console.WriteLine($"\nOrder #3 Total Cost: {order3.CalculateTotalCost()}");
        Console.WriteLine("Packing Label:");
        Console.WriteLine("===========================");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine("===========================");
        Console.WriteLine(customer3.GetFullAddress());
    }
}