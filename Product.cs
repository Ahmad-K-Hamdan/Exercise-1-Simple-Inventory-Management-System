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
}