class Program
{
    public static void Main()
    {
        Product myProduct = new Product("apples", 12.1f, 50);
        Product myProduct2 = new Product("bananas", 5.3f, 10);

        Inventory myInv = new Inventory();

        myInv.AddProduct(myProduct);
        myInv.AddProduct(myProduct2);
        myInv.ListAllProducts();
        Console.WriteLine("\n");

        myInv.RemoveProduct("apples");
        Console.WriteLine("...........");
        myInv.ListAllProducts();
        Console.WriteLine("...........");
        myInv.RemoveProduct("apples");
        Console.WriteLine("...........");
        myInv.RemoveProduct("bananas");
        Console.WriteLine("...........");

        myInv.ListAllProducts();
    }
}