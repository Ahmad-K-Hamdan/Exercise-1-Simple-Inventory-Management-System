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
            ProductValidator.ValidateName(value);
            _name = value;
        }
    }

    private float _price;
    public float Price
    {
        get => _price;
        set
        {
            ProductValidator.ValidatePrice(value);
            _price = value;
        }
    }

    private int _quantity;
    public int Quantity
    {
        get => _quantity;
        set
        {
            ProductValidator.ValidateQuantity(value);
            _quantity = value;
        }
    }

    public override string ToString()
    {
        return "Name = " + Name + ", Price = " + Price + ", Quantity = " + Quantity;
    }
}