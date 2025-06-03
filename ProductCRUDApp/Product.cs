namespace ProductCRUDApp;

/// <summary>
/// Represents a single product for sale
/// </summary>
public class Product
{

    /// <summary>
    /// Gets or sets the unique identifier for the product. The
    /// database will generate this value for new products. Leave
    /// at 0 if this is new
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Gets or sets the name of the product. Acceptable characters
    /// are A-Z (case insensitive) and digits. Can be up to 150 characters
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Gets or sets the sales price of the product. Price must be greater than 0
    /// </summary>
    public double Price { get; set; }
}