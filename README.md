# Simple Inventory Management System

A straightforward inventory tracker built in C#. It allows users to add, update, and remove products, with validation logic to ensure data integrity.

## 🚀 Features

- **Add and manage products**: specify name, price, and quantity.
- **Input validation**: verifies non-empty names, positive price, and non-negative quantity.
- Modular design: validation logic separated from core operations.

## 🧱 Project Structure

```
  Program.cs
  Product.cs
  ProductValidator.cs
  InventoryService.cs
  ErrorMessages.cs
```

- `ProductValidator.cs`: contains validation methods using constants from `ErrorMessages`.
- `InventoryService.cs`: holds logic for CRUD operations on products.
- `Models/Product.cs`: defines the `Product` model with its properties.

## ⚙️ Requirements

- .NET Core 7.0 (or .NET 8.0)
- Compatible development environment (Visual Studio, Visual Studio Code, JetBrains Rider)
- [Optional] NuGet packages: e.g. *Newtonsoft.Json* (if persistence or serialization is included)

## 🛠 Usage

1. Clone the repository:

   ```bash
   git clone https://github.com/Ahmad-K-Hamdan/Exercise-1-Simple-Inventory-Management-System.git
   cd Exercise-1-Simple-Inventory-Management-System
   ```

2. Open in your IDE of choice.

3. Run the application:

   ```bash
   dotnet run --project src
   ```

4. Interact via the console interface (CLI) to add, list, update, and delete products.

## 📄 Validation Rules

- **Name**  
  - Must not be null or whitespace  
  - Must contain only letters

- **Price**  
  - Must be greater than 0

- **Quantity**  
  - Must be zero or positive

Messages are stored in `ErrorMessages.cs`, e.g.:

```csharp
public static class ErrorMessages
{
    public const string NameNullOrWhitespace = "Name cannot be null or white space";
    public const string NameOnlyLetters = "Name can only contain letters";
    public const string PriceMustBePositive = "Price must be positive";
    public const string QuantityCannotBeNegative = "Quantity cannot be negative";
}
```

## 🧪 Sample Usage Flow

```
Welcome to Inventory Manager!
1. Add Product
2. List Products
3. Update Product
4. Delete Product
5. Exit
```

- Adding a product triggers validation via `ProductValidator`.
- If validation fails, an `ArgumentException` is thrown with a message from `ErrorMessages`.
- Successful additions update the internal in-memory inventory list.

## 📦 Extending the Project

Here are some ideas for possible enhancements:

- **Persistence**: Add file-based (JSON/XML) or database support.
- **Localization**: Switch to `.resx` resource files to support multiple languages.
- **User Interface**: Add a GUI (WPF) or web frontend (ASP.NET Core MVC / Blazor).
- **Validation Frameworks**: Use fluent validation or data annotations for richer validation rules.
- **Stock Controls**: Add minimum/maximum thresholds, automatic reorder alerts, reporting.

## 📝 Contributing

Feel free to fork the repository and submit PRs, suggest improvements, or report bugs via GitHub issues.
