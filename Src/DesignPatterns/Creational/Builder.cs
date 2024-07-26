namespace DesignPatterns;

public class Product
{
    public string PartA { get; internal set; }
    public string PartB { get; internal set; }
    public string PartC { get; internal set; }
}

public interface IProductBuilder
{
    void BuildPartA();
    void BuildPartB();
    void BuildPartC();
    Product GetProduct();
}

public sealed class ProductBuilder : IProductBuilder
{
    private Product _product = new Product();

    public void BuildPartA()
    {
        _product.PartA = "Part A";
    }

    public void BuildPartB()
    {
        _product.PartB = "Part B";
    }

    public void BuildPartC()
    {
        _product.PartC = "Part C";
    }

    public Product GetProduct()
    {
        Product result = _product;
        _product = new Product();  // Reset for the next build process
        return result;
    }
}

public sealed class Director
{
    private IProductBuilder _builder;

    public IProductBuilder Builder
    {
        set { _builder = value; }
    }

    // The Director can construct several product variations using the same building steps
    public void BuildMinimalViableProduct()
    {
        _builder.BuildPartA();
    }

    public void BuildFullFeaturedProduct()
    {
        _builder.BuildPartA();
        _builder.BuildPartB();
        _builder.BuildPartC();
    }
}