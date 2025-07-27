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
        EditProductDetails(product);
    }

    private void EditProductDetails(Product product)
    {
        Console.WriteLine("What would you like to edit?");
        Console.WriteLine("1. Product's Name");
        Console.WriteLine("2. Product's Price");
        Console.WriteLine("3. Product's Quantity");

        string inputChoice = Console.ReadLine();
        bool canConvert = int.TryParse(inputChoice, out int choice);
        if (!canConvert || (choice > 3 || choice < 1))
        {
            Console.WriteLine("Invalid Choice.\n");
            return;
        }

        try
        {
            bool edited = false;
            if (choice == 1)
            {
                Console.Write("Enter the new name for the product: ");
                product.Name = Console.ReadLine();
                edited = true;
            }
            else if (choice == 2)
            {
                Console.Write("Enter the new price for the product: ");
                if (float.TryParse(Console.ReadLine(), out float newPrice))
                {
                    product.Price = newPrice;
                    edited = true;
                }
                else
                {
                    Console.WriteLine("Invalid Price.\n");
                }
            }
            else if (choice == 3)
            {
                Console.Write("Enter the new quantity for the product: ");
                if (int.TryParse(Console.ReadLine(), out int newQuantity))
                {
                    product.Quantity = newQuantity;
                    edited = true;
                }
                else
                {
                    Console.WriteLine("Invalid Quantity.\n");
                }
            }
            if (edited)
            {
                Console.WriteLine("Edit successful!\n");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
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
