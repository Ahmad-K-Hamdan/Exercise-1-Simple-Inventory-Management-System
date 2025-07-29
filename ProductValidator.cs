public static class ProductValidator
{
    public static void ValidateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException(ErrorMessages.NameNullOrWhitespace);

        name = name.Trim();
        if (!name.All(char.IsLetter))
            throw new ArgumentException(ErrorMessages.NameOnlyLetters);
    }

    public static void ValidatePrice(float price)
    {
        if (price <= 0)
            throw new ArgumentException(ErrorMessages.PriceMustBePositive);
    }

    public static void ValidateQuantity(int quantity)
    {
        if (quantity < 0)
            throw new ArgumentException(ErrorMessages.QuantityCannotBeNegative);
    }
}
