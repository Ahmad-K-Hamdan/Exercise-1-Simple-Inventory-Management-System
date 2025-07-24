using System.Xml.Linq;

class Program
{
    public static void Main()
    {
        Console.WriteLine("*****************************************************************");
        Console.WriteLine("\tWelcome to the Simple Inventory Management System.");
        Console.WriteLine("*****************************************************************");

        Inventory inventory = new Inventory();

        int option;
        while (true)
        {
            option = MainMenu();
            string productName;
            switch (option)
            {
                case 1:
                    var product = CreateProduct();
                    inventory.AddProduct(product);
                    break;
                case 2:
                    inventory.ListAllProducts();
                    break;
                case 3:
                    Console.Write("Enter the name of the product: ");
                    productName = Console.ReadLine();
                    inventory.EditProduct(productName);
                    break;
                case 4:
                    Console.Write("Enter the name of the product to delete: ");
                    productName = Console.ReadLine();
                    inventory.RemoveProduct(productName);
                    break;
                case 5:
                    break;
                case 6:
                    Console.WriteLine("Thank you for using our system.");
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("An error has occured.");
                    Environment.Exit(1);
                    break;
            }
        }

    }

    private static int MainMenu()
    {
        int choice = 0;
        bool canConvert = false;

        while (!canConvert || choice < 1 || choice > 6)
        {
            Console.WriteLine("Our available functionalities:");
            Console.WriteLine("1. Add a product");
            Console.WriteLine("2. View all products");
            Console.WriteLine("3. Edit a product");
            Console.WriteLine("4. Delete a product");
            Console.WriteLine("5. Search for a product");
            Console.WriteLine("6. Exit");
            Console.Write("Please choose an option: ");

            string inputChoice = Console.ReadLine();
            canConvert = int.TryParse(inputChoice, out choice);

            if (!canConvert || choice < 1 || choice > 6)
            {
                Console.WriteLine("Invalid Choice.\n");
            }
        }

        return choice;
    }

    private static Product CreateProduct()
    {
        while (true)
        {
            try
            {
                Console.Write("Enter the name of the product: ");
                string productName = Console.ReadLine();

                Console.Write("Enter the price of the product: ");
                if (!float.TryParse(Console.ReadLine(), out float productPrice))
                    throw new ArgumentException("Invalid price input.");

                Console.Write("Enter the quantity of the product: ");
                if (!int.TryParse(Console.ReadLine(), out int productQuantity))
                    throw new ArgumentException("Invalid quantity input.");

                return new Product(productName, productPrice, productQuantity);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}\nPlease try again.\n");
            }
        }
    }
}