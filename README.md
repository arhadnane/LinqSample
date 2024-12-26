# LinqSample

This project demonstrates the usage of LINQ (Language Integrated Query) in C# to work with collections of data. It provides examples of various LINQ operations such as filtering, ordering, grouping, and transforming data, showcasing the powerful features LINQ offers for querying in-memory collections.

### Features

- **LINQ Query Syntax**: Examples of LINQ queries written in query syntax.
- **LINQ Method Syntax**: Examples of LINQ queries written using method chaining.
- **Filtering**: Demonstrating `Where` and conditional queries.
- **Projection**: Using `Select` to transform data.
- **Sorting**: Sorting collections using `OrderBy` and `ThenBy`.
- **Grouping**: Grouping data using `GroupBy`.
- **Aggregating**: Using aggregation operators like `Sum`, `Count`, `Max`, `Min`, and `Average`.
- **Joining**: Performing joins between different collections.
- **Deferred Execution**: Understanding the concept of deferred execution in LINQ.

### Project Structure

- `Program.cs`: The main entry point for the sample code, where LINQ queries and examples are implemented.
- `Data`: Contains sample collections of data (e.g., `List<Customer>`, `List<Order>`) used for the LINQ queries.

### Prerequisites

To run this project, you need to have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or higher)
- A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Getting Started

1. Clone the repository to your local machine:

   ```bash
   git clone https://github.com/arhadnane/LinqSample.git
   ```

2. Navigate to the project directory:

   ```bash
   cd LinqSample
   ```

3. Open the project in your preferred IDE or editor.

4. Build and run the project:

   ```bash
   dotnet run
   ```

### Usage

The `Program.cs` file contains various LINQ examples. Below are some example queries:

- **Example 1: Filtering data with `Where`**:

    ```csharp
    var customers = GetCustomers();
    var filteredCustomers = customers.Where(c => c.Age > 30).ToList();
    ```

- **Example 2: Sorting data with `OrderBy`**:

    ```csharp
    var sortedCustomers = customers.OrderBy(c => c.Name).ToList();
    ```

- **Example 3: Grouping data with `GroupBy`**:

    ```csharp
    var groupedCustomers = customers.GroupBy(c => c.City);
    ```

- **Example 4: Projection with `Select`**:

    ```csharp
    var customerNames = customers.Select(c => c.Name).ToList();
    ```

- **Example 5: Aggregation with `Sum`**:

    ```csharp
    var totalOrderAmount = orders.Sum(o => o.Amount);
    ```

Each example showcases a different LINQ operation and can be run individually in the `Main` method. Modify the sample collections or queries to explore more possibilities!

### Additional Resources

- [Official LINQ Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq)
- [LINQ in C# - TutorialsPoint](https://www.tutorialspoint.com/linq/)

### License

This project is licensed under the MIT License
