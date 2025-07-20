public class Product
{
    public string Name;
    public string ProductId;
    public double Price;
    public int Quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public double GetTotalCost()
    {
        return Price * Quantity;
    }
}
