public static class ProductValidator
{
    public static void ValidateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be null or white space");

        name = name.Trim();
        if (!name.All(char.IsLetter))
            throw new ArgumentException("Name can only contain letters");
    }

    public static void ValidatePrice(float price)
    {
        if (price <= 0)
            throw new ArgumentException("Price must be positive");
    }

    public static void ValidateQuantity(int quantity)
    {
        if (quantity < 0)
            throw new ArgumentException("Quantity cannot be negative");
    }
}
