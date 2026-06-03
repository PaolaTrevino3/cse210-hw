using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 River Street", "New York", "NY", "USA");
        Customer customer1 = new Customer("Paola Trevino", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop Case", "LC100", 25.99, 2));
        order1.AddProduct(new Product("Wireless Mouse", "WM200", 14.50, 1));

        Address address2 = new Address("45 Maple Road", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Sofia Martinez", address2);
        
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "NB300", 6.99, 5));
        order2.AddProduct(new Product("Desk Lamp", "DL400", 32.75, 1));

        DisplayOrder(order1, 1);
        DisplayOrder(order2, 2);
    }   

    static void DisplayOrder(Order order, int orderNumber)
    {
        Console.WriteLine($"Order {orderNumber}:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
        Console.WriteLine("-----------------------------");
    }
}