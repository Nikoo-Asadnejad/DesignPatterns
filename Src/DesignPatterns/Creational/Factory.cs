namespace DesignPatterns.Creational;

public interface IProductService
{
    string GetProduct();
}

public class ProductServiceA : IProductService
{
    public string GetProduct()
    {
        return "ConcreteProductA";
    }
}

public class ProductServiceB : IProductService
{
    public string GetProduct()
    {
        return "ConcreteProductB";
    }
}

public static class ProductFactory
{
    public static IProductService CreateProduct(string productType)
    {
        switch (productType.ToLower())
        {
            case "a":
                return new ProductServiceA();
            case "b":
                return new ProductServiceB();
            default:
                throw new ArgumentException("Invalid product type", nameof(productType));
        }
    }
}