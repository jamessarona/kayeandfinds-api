namespace KayeAndFinds.Domain.Entities;

public class Product : Entity<Guid>
{
    public string Name { get; set; } = default!;
    public ProductCategory ProductCategory { get; set; } = ProductCategory.Clothing;
    public string Brand { get; set; } = default!;
    public string Condition { get; set; } = default!;
    public string Size { get; set; } = default!;
    public string Color { get; set; } = default!;

    public static Product Create(Guid id, string name, ProductCategory productCategory,
        string brand, string condition, string size, string color)
    {
        var product = new Product
        {
            Id = id,
            Name = name,
            ProductCategory = productCategory,
            Brand = brand,
            Condition = condition,
            Size = size,
            Color = color
        };

        return product;
    }
}