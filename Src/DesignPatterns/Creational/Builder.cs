namespace DesignPatterns;

public class Product
{
    public string PartA { get; set; }
    public string PartB { get; set; }
    public string PartC { get; set; }
}
public interface IBuilder
{
    void BuildPartA();
    void BuildPartB();
    void BuildPartC();
    Product GetProduct();
}
public class ConcreteBuilder : IBuilder
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

public class Director
{
    private IBuilder _builder;

    public IBuilder Builder
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