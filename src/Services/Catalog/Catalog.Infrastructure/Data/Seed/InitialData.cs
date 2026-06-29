namespace Catalog.Infrastructure.Data.Seed;

public static class InitialData
{
    private static readonly Brand Apple = Brands.ElementAt(0);
    private static readonly Brand Samsung = Brands.ElementAt(1);
    private static readonly Brand Xiaomi = Brands.ElementAt(2);
    private static readonly Brand Huawei = Brands.ElementAt(3);
    private static readonly Brand Sony = Brands.ElementAt(4);
    private static readonly Brand Lg = Brands.ElementAt(5);
    private static readonly Brand Lenovo = Brands.ElementAt(6);
    private static readonly Brand Asus = Brands.ElementAt(7);
    private static readonly Brand Dell = Brands.ElementAt(8);
    private static readonly Brand Hp = Brands.ElementAt(9);

    private static readonly Category Laptops = Categories.ElementAt(0);
    private static readonly Category Smartphones = Categories.ElementAt(1);
    private static readonly Category Tablets = Categories.ElementAt(2);
    private static readonly Category Monitors = Categories.ElementAt(3);
    private static readonly Category Keyboards = Categories.ElementAt(4);
    private static readonly Category Mice = Categories.ElementAt(5);
    private static readonly Category Headphones = Categories.ElementAt(6);
    private static readonly Category Smartwatches = Categories.ElementAt(7);
    private static readonly Category Cameras = Categories.ElementAt(8);
    private static readonly Category Accessories = Categories.ElementAt(9);

    public static IEnumerable<Brand> Brands { get; } = [
        new() { Id = Guid.Parse("a1b2c3d4-1111-1111-1111-111111111111"), Title = "Apple" },
        new() { Id = Guid.Parse("a1b2c3d4-2222-2222-2222-222222222222"), Title = "Samsung" },
        new() { Id = Guid.Parse("a1b2c3d4-3333-3333-3333-333333333333"), Title = "Xiaomi" },
        new() { Id = Guid.Parse("a1b2c3d4-4444-4444-4444-444444444444"), Title = "Huawei" },
        new() { Id = Guid.Parse("a1b2c3d4-5555-5555-5555-555555555555"), Title = "Sony" },
        new() { Id = Guid.Parse("a1b2c3d4-6666-6666-6666-666666666666"), Title = "LG" },
        new() { Id = Guid.Parse("a1b2c3d4-7777-7777-7777-777777777777"), Title = "Lenovo" },
        new() { Id = Guid.Parse("a1b2c3d4-8888-8888-8888-888888888888"), Title = "Asus" },
        new() { Id = Guid.Parse("a1b2c3d4-9999-9999-9999-999999999999"), Title = "Dell" },
        new() { Id = Guid.Parse("a1b2c3d4-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), Title = "HP" },
    ];

    public static IEnumerable<Category> Categories { get; } = [
        new() { Id = Guid.Parse("b2c3d4a1-1111-1111-1111-111111111111"), Title = "Laptops" },
        new() { Id = Guid.Parse("b2c3d4a1-2222-2222-2222-222222222222"), Title = "Smartphones" },
        new() { Id = Guid.Parse("b2c3d4a1-3333-3333-3333-333333333333"), Title = "Tablets" },
        new() { Id = Guid.Parse("b2c3d4a1-4444-4444-4444-444444444444"), Title = "Monitors" },
        new() { Id = Guid.Parse("b2c3d4a1-5555-5555-5555-555555555555"), Title = "Keyboards" },
        new() { Id = Guid.Parse("b2c3d4a1-6666-6666-6666-666666666666"), Title = "Mice" },
        new() { Id = Guid.Parse("b2c3d4a1-7777-7777-7777-777777777777"), Title = "Headphones" },
        new() { Id = Guid.Parse("b2c3d4a1-8888-8888-8888-888888888888"), Title = "Smartwatches" },
        new() { Id = Guid.Parse("b2c3d4a1-9999-9999-9999-999999999999"), Title = "Cameras" },
        new() { Id = Guid.Parse("b2c3d4a1-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), Title = "Accessories" },
    ];

    public static IEnumerable<CatalogItem> CatalogItems =>
    [
        new() { Id = Guid.Parse("c3d4a1b2-0001-0001-0001-000000000001"), Title = "MacBook Pro 16", ShortDescription = "Powerful laptop for professionals", FullDescription = "The most powerful MacBook ever with M4 chip", ImageUrl = "https://example.com/images/macbook-pro-16.jpg", Price = 2499.99m, Brand = Apple, Category = Laptops },
        new() { Id = Guid.Parse("c3d4a1b2-0002-0002-0002-000000000002"), Title = "Samsung Galaxy S25", ShortDescription = "Flagship smartphone", FullDescription = "Galaxy S25 with AI features and exceptional camera", ImageUrl = "https://example.com/images/galaxy-s25.jpg", Price = 1199.99m, Brand = Samsung, Category = Smartphones },
        new() { Id = Guid.Parse("c3d4a1b2-0003-0003-0003-000000000003"), Title = "iPad Pro M4", ShortDescription = "High-performance tablet", FullDescription = "iPad Pro with M4 chip and Liquid Retina XDR display", ImageUrl = "https://example.com/images/ipad-pro-m4.jpg", Price = 1099.99m, Brand = Apple, Category = Tablets },
        new() { Id = Guid.Parse("c3d4a1b2-0004-0004-0004-000000000004"), Title = "Dell UltraSharp 32", ShortDescription = "Professional 4K monitor", FullDescription = "32-inch 4K IPS monitor with factory-calibrated colors", ImageUrl = "https://example.com/images/dell-ultrasharp-32.jpg", Price = 1299.99m, Brand = Dell, Category = Monitors },
        new() { Id = Guid.Parse("c3d4a1b2-0005-0005-0005-000000000005"), Title = "Logitech MX Keys", ShortDescription = "Wireless keyboard", FullDescription = "Premium wireless keyboard with backlighting and multi-device support", ImageUrl = "https://example.com/images/logitech-mx-keys.jpg", Price = 119.99m, Category = Keyboards },
        new() { Id = Guid.Parse("c3d4a1b2-0006-0006-0006-000000000006"), Title = "Logitech MX Master 3S", ShortDescription = "Wireless mouse", FullDescription = "Ergonomic wireless mouse with 8K DPI sensor", ImageUrl = "https://example.com/images/mx-master-3s.jpg", Price = 99.99m, Category = Mice },
        new() { Id = Guid.Parse("c3d4a1b2-0007-0007-0007-000000000007"), Title = "Sony WH-1000XM6", ShortDescription = "Noise-cancelling headphones", FullDescription = "Industry-leading noise cancellation with superior sound quality", ImageUrl = "https://example.com/images/sony-wh-1000xm6.jpg", Price = 349.99m, Brand = Sony, Category = Headphones },
        new() { Id = Guid.Parse("c3d4a1b2-0008-0008-0008-000000000008"), Title = "Apple Watch Ultra 3", ShortDescription = "Premium smartwatch", FullDescription = "Most rugged Apple Watch with titanium case and extended battery", ImageUrl = "https://example.com/images/apple-watch-ultra-3.jpg", Price = 799.99m, Brand = Apple, Category = Smartwatches },
        new() { Id = Guid.Parse("c3d4a1b2-0009-0009-0009-000000000009"), Title = "Sony A7 V", ShortDescription = "Full-frame mirrorless camera", FullDescription = "Professional-grade 61MP full-frame camera with AI autofocus", ImageUrl = "https://example.com/images/sony-a7v.jpg", Price = 3499.99m, Brand = Sony, Category = Cameras },
        new() { Id = Guid.Parse("c3d4a1b2-0010-0010-0010-000000000010"), Title = "Anker PowerCore 26800", ShortDescription = "Portable power bank", FullDescription = "High-capacity 26800mAh portable charger with dual USB-C", ImageUrl = "https://example.com/images/anker-powercore.jpg", Price = 65.99m, Category = Accessories },
    ];
}
