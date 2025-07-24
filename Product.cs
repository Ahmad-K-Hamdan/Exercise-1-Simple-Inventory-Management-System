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
                throw new ArgumentException("Name cannot be null or white space");
            value = value.Trim();
            if (!value.All(char.IsLetter))
                throw new ArgumentException("Name can only contain letters");
            _name = value;
        }
    }


    private float _price;
    public float Price
    {
        get => _price;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Price cannot be non-positive");
            _price = value;
        }
    }


    private int _quantity;
    public int Quantity
    {
        get => _quantity;
        set
        {
            if (value < 0)
                throw new ArgumentException("Quantity cannot be negative");
            _quantity = value;
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

        try
        {
            if (choice == 1)
            {
                Console.Write("Enter the new name for the product: ");
                Name = Console.ReadLine();
            }
            else if (choice == 2)
            {
                Console.Write("Enter the new price for the product: ");
                if (float.TryParse(Console.ReadLine(), out float newPrice))
                    Price = newPrice;
                else
                    Console.WriteLine("Invalid Price.");
            }
            else if (choice == 3)
            {
                Console.Write("Enter the new quantity for the product: ");
                if (int.TryParse(Console.ReadLine(), out int newQuantity))
                    Quantity = newQuantity;
                else
                    Console.WriteLine("Invalid Quantity.");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}