public static class Fabricator
{
    public static IProduct CreateProduct(string type)
    {
        return type switch
        {
            "A" => new ProductA(),
            "B" => new ProductB(),
            _ => throw new ArgumentException("Invalid product type"),
        };
    }
}