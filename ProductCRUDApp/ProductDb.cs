using Microsoft.Data.SqlClient;

namespace ProductCRUDApp;

public static class ProductDb
{
    /// <summary>
    /// Connection string to the local SQL Server database with the name "ProductDb" for the DB.
    /// Using Windows Authentication (Trusted Connection).
    /// </summary>
    private const string DbConnection = "Data Source=localhost;Initial Catalog=ProductDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

    public static void AddProduct(Product p)
    {
        throw new NotImplementedException();
    }

    public static void DeleteProduct(Product p) 
    {
        throw new NotImplementedException(); 
    }

    public static void DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Retrieves a list of all available products from the local SQL Server database
    /// </summary>
    /// <remarks>This method provides a complete collection of products.</remarks>
    /// <returns>A list of <see cref="Product"/> objects representing all available products.  
    /// The list will be empty if no products are available.</returns>
    /// <exception cref="SqlException">May be thrown if database is not available</exception>
    public static List<Product> GetAllProducts()
    {
        // Connect to the database
        SqlConnection con = new(DbConnection);

        // Create the query
        string query = "SELECT ProductId, Name, Price FROM Product;";

        // Open the connection
        con.Open();

        // Execute the query and read the results
        SqlCommand cmd = new(query, con);
        SqlDataReader reader = cmd.ExecuteReader();
        List<Product> products = new();

        while (reader.Read())
        {
            // Create a new Product object for each row
            Product product = new()
            {
                ProductId = Convert.ToInt32(reader[0]), // ProductId
                Name = reader[1].ToString(),      // Name
                Price = Convert.ToDouble(reader[2])     // Price
            };
            products.Add(product);
        }

        // Close the connection
        con.Close();

        // Return the list of products
        return products;
    }
}