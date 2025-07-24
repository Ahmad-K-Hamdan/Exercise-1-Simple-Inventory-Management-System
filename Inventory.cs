class Inventory
{
    public List<Product> Products { get; } = [];

    public void AddProduct(Product product)
    {
        Products.Add(product);
        Console.WriteLine("Sucessfuly added the product.");
    }
}
