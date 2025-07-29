using System.Xml.Linq;

class Program
{
    public static void Main()
    {
        Console.WriteLine("*****************************************************************");
        Console.WriteLine("\tWelcome to the Simple Inventory Management System.");
        Console.WriteLine("*****************************************************************");

        var inventory = new Inventory();

        int option;
        while (true)
        {
            option = MainMenu();
            string productName;
            switch (option)
            {
                case 1:
                    var product = Inventory.CreateProduct();
                    inventory.AddProduct(product);
                    break;
                case 2:
                    inventory.ListAllProducts();
                    break;
                case 3:
                    Console.Write("Enter the name of the product to edit: ");
                    productName = Console.ReadLine();
                    inventory.EditProduct(productName);
                    break;
                case 4:
                    Console.Write("Enter the name of the product to delete: ");
                    productName = Console.ReadLine();
                    inventory.RemoveProduct(productName);
                    break;
                case 5:
                    Console.Write("Enter the name of the product to search for: ");
                    productName = Console.ReadLine();
                    inventory.SearchForProduct(productName);
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
        var choice = 0;
        var canConvert = false;

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

            var inputChoice = Console.ReadLine();
            canConvert = int.TryParse(inputChoice, out choice);

            if (!canConvert || choice is < 1 or > 6)
            {
                Console.WriteLine("Invalid Choice.\n");
            }
        }

        return choice;
    }
}