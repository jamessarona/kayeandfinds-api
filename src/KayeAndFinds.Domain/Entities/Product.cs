using KayeAndFinds.Domain.Enums;

namespace KayeAndFinds.Domain.Entities;

public class Product
{
    public string Name { get; set; } = default!;
    public ProductCategory ProductCategory { get; set; } = ProductCategory.Clothing;
    public string Brand { get; set; } = default!;
    public string Condition { get; set; } = default!;
    public string Size { get; set; } = default!;
    public string Color { get; set; } = default!;
}