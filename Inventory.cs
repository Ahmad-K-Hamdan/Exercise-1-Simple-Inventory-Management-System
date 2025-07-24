class Inventory
{
    public List<Product> Products { get; } = [];

    public void AddProduct(Product product)
    {
        Products.Add(product);
        Console.WriteLine("Sucessfuly added the product.");
    }

    public void ListAllProducts()
    {
        foreach (Product product in Products)
            Console.WriteLine(product.ToString());
    }
}
