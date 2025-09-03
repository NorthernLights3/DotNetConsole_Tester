public class ProductA : IProduct
{
    public string Name { get; set; } = "Product A";
    public decimal Cost { get; set; } = 10.0m;
}

public class ProductB : IProduct
{
    public string Name { get; set; } = "Product B";
    public decimal Cost { get; set; } = 20.0m;
}