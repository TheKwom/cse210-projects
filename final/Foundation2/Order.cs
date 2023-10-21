using System;
class Order
{
    private Customer Customer { get; set; }
    private List<Product> Products { get; set; }

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (Product product in Products)
        {
            total += product.CalculateTotalPrice();
        }

        if (Customer.IsInUSA())
        {
            total += 5.0; // USA shipping cost
        }
        else
        {
            total += 35.0; // Non-USA shipping cost
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in Products)
        {
            label += $"{product.Name} ({product.ProductId})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + Customer.Address.GetFullAddress();
    }
}