class Inventory
{
    public List<Product> Products { get; } = [];

    public void AddProduct(Product product)
    {
        Products.Add(product);
        Console.WriteLine("Successfully added the product.");
    }

    public void ListAllProducts()
    {
        foreach (Product product in Products)
            Console.WriteLine(product.ToString());
    }

    public Product? FindProductByName(string productName)
    {
        foreach (Product product in Products)
            if (productName.Equals(product.Name))
                return product;
        return null;
    }

    public void EditProduct(string productName)
    {
        var product = FindProductByName(productName);
        if (product != null)
            product.Edit();
        else
            Console.WriteLine("The desired product was not found.");
    }
}
