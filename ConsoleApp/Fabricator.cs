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

    public static async Task<List<IProduct>> GetProductsAsync()
    {
        // Simulate an asynchronous operation
        await Task.Delay(15);
        return new List<IProduct>() { CreateProduct("A"), CreateProduct("B"), CreateProduct("B"), CreateProduct("A"), CreateProduct("A") };
    }
}