class Product
{
    public Product(string name, float price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine($"Error! Name cannot be null or white space");
                return;
            }
            value = value.Trim();
            if (value.All(Char.IsLetter))
                _name = value;
            else
                Console.WriteLine($"Error! Input: {value}. Name can only contain characters");
        }
    }


    private float _price;
    public float Price
    {
        get => _price;
        set
        {
            if (value > 0)
                _price = value;
            else
                Console.WriteLine($"Error! Input: {value}. Price cannot be non-positive");
        }
    }


    private int _quantity;
    public int Quantity
    {
        get => _quantity;
        set
        {
            if (value >= 0)
                _quantity = value;
            else
                Console.WriteLine($"Error! Input: {value}. Quantity cannot be negative");
        }
    }

    public override string ToString()
    {
        return "Name = " + Name + ", Price = " + Price + ", Quantity = " + Quantity;
    }

    public void Edit()
    {
        Console.WriteLine("What would you like to edit?");
        Console.WriteLine("1. Product's Name");
        Console.WriteLine("2. Product's Price");
        Console.WriteLine("3. Product's Quantity");
        string inputChoice = Console.ReadLine();
        bool canConvert = int.TryParse(inputChoice, out int choice);
        if (!canConvert || (choice > 3 || choice < 1))
        {
            Console.WriteLine("Invalid Choice.");
            return;
        }

        if (choice == 1)
        {
            Console.Write("Enter the new name for the product: ");
            string newName = Console.ReadLine();
            Name = newName;
        }
        else if (choice == 2)
        {
            Console.Write("Enter the new price for the product: ");
            string inputPrice = Console.ReadLine();
            canConvert = float.TryParse(inputPrice, out float newPrice);
            if (!canConvert)
            {
                Console.WriteLine("Invalid Price.");
                return;
            }
            Price = newPrice;
        }
        if (choice == 3)
        {
            Console.Write("Enter the new quantity for the product: ");
            string inputQuantity = Console.ReadLine();
            canConvert = int.TryParse(inputQuantity, out int newQuantity);
            if (!canConvert)
            {
                Console.WriteLine("Invalid Quantity.");
                return;
            }
            Quantity = newQuantity;
        }
    }
}