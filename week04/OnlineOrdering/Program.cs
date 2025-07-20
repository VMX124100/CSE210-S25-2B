class Program
{
    static void Main(string[] args)
    {
        Address addressUSA1 = new Address("123 Main St", "Anytown", "IL", "USA");
        Customer customerUSA1 = new Customer("John Strong", addressUSA1);

        List<Product> PC1 = new List<Product>       //PC1 = Products Customer 1
        {
            new Product("Laptop", "LP-123", 999.99, 2),
            new Product("Mouse", "MS-456", 25.50, 2),
            new Product("Keyboard", "KB-789", 45.00, 2)
        };

        Order orderUSA1 = new Order(customerUSA1, PC1);

        Address addressIntl1 = new Address("456 Wonderland Rd", "Faketown", "XY", "Canada");
        Customer customerIntl1 = new Customer("Jane Mary", addressIntl1);

        List<Product> PCI1 = new List<Product>      //PCI1 = Products Customer International 1
        {
            new Product("Tablet", "TB-001", 300.00, 5),
            new Product("Case", "CS-002", 20.00, 2)
        };

        Order orderIntl1 = new Order(customerIntl1, PCI1);

        Console.WriteLine();
        Console.WriteLine(orderUSA1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(orderUSA1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total product cost: ${orderUSA1.CalculateProductTotalCost():0.00}");
        Console.WriteLine($"Shipping Cost: ${orderUSA1.GetShippingCost()}");
        Console.WriteLine($"Total Order Cost: ${orderUSA1.CalculateTotalCost():0.00}");

        Console.WriteLine("\n-------------------------\n");

        Console.WriteLine(orderIntl1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(orderIntl1.GetShippingLabel());
        Console.WriteLine($"Total product cost: ${orderIntl1.CalculateProductTotalCost():0.00}");
        Console.WriteLine($"Shipping Cost: ${orderIntl1.GetShippingCost()}");
        Console.WriteLine($"Total Order Cost: ${orderIntl1.CalculateTotalCost():0.00}");
    }
}
