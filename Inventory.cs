class Inventory
{
    public List<Product> Products { get; } = new();

    private bool IsInventoryEmpty()
    {
        if (Products.Count == 0)
        {
            Console.WriteLine("The inventory is empty.\n");
            return true;
        }
        return false;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
        Console.WriteLine($"Successfully added {product.Name} to the inventory.\n");
    }

    public void ListAllProducts()
    {
        IsInventoryEmpty();
        foreach (var product in Products)
            Console.WriteLine(product.ToString());
        Console.WriteLine();
    }

    public Product? FindProductByName(string productName)
    {
        foreach (var product in Products)
            if (productName.Equals(product.Name))
            {
                return product;
            }
        return null;
    }

    public void EditProduct(string productName)
    {
        if (IsInventoryEmpty())
        {
            return;
        }
        var product = FindProductByName(productName);
        if (product is null)
        {
            Console.WriteLine("The desired product was not found.\n");
            return;
        }
        product.Edit();
    }

    public void SearchForProduct(string productName)
    {
        if (IsInventoryEmpty())
        {
            return;
        }
        var product = FindProductByName(productName);
        if (product is null)
        {
            Console.WriteLine("The desired product was not found.\n");
            return;
        }
        Console.WriteLine(product.ToString());
        Console.WriteLine();
    }

    public void RemoveProduct(string productName)
    {
        if (IsInventoryEmpty())
        {
            return;
        }
        var product = FindProductByName(productName);
        if (product is null)
        {
            Console.WriteLine("The desired product was not found.\n");
            return;
        }
        Products.Remove(product);
        Console.WriteLine($"Successfully removed {product.Name} from the inventory.\n");
    }
}
