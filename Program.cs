class Program
{
    public static void Main()
    {
        Product myProduct = new Product("apples", 12.1f, 50);
        Console.WriteLine(myProduct.ToString());
        myProduct.Name = "bananas41";
        myProduct.Price = 20f;
        myProduct.Quantity = -3;
        Console.WriteLine(myProduct.ToString());
    }
}