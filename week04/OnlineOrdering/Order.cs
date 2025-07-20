public class Order
{
    private List<Product> Products;
    private Customer Customer;

    public Order(Customer customer, List<Product> products)
    {
        Customer = customer;
        Products = products;
    }

    public int GetShippingCost()
    {
        if (Customer.LivesInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public double CalculateProductTotalCost()
    {
        double productsTotal = 0;
        foreach (var product in Products)
        {
            productsTotal += product.GetTotalCost();
        }
        return productsTotal;
    }

    public double CalculateTotalCost()
    {
        return CalculateProductTotalCost() + GetShippingCost();
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in Products)
        {
            label += $"Product: {product.Name}, Product ID: {product.ProductId}, Quantity: {product.Quantity}, Price each: {product.Price}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\nCustomer: {Customer.Name}\nAddress: {Customer.Address.FullAddress()}";
    }





}
