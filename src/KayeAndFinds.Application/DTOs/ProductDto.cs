namespace KayeAndFinds.Application.DTOs;

public record ProductDto(
    Guid Id,
    string Name,
    ProductCategory ProductCategory,
    string Brand,
    string Condition,
    string Size,
    string Color);