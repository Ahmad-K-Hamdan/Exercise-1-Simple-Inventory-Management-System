class Inventory
{
    public List<Product> Products { get; } = [];

    public void AddProduct(Product product)
    {
        Products.Add(product);
        Console.WriteLine($"Successfully added {product.Name} to the inventory.\n");
    }

    public void ListAllProducts()
    {
        if (Products.Count == 0)
            Console.WriteLine("The inventory is empty.");
        foreach (Product product in Products)
            Console.WriteLine(product.ToString());
        Console.WriteLine();
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

    public void SearchForProduct(string productName)
    {
        var product = FindProductByName(productName);
        if (product != null)
            Console.WriteLine(product.ToString());
        else
            Console.WriteLine("The desired product was not found.");
    }

    public void RemoveProduct(string productName)
    {
        var product = FindProductByName(productName);
        if (product != null)
        {
            Products.Remove(product);
            Console.WriteLine($"Successfully removed {product.Name} from the inventory.");
        }
        else
            Console.WriteLine("The desired product was not found.");
    }
}
