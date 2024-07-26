namespace DesignPatterns.Creational;

public interface IPrototype
{
    IPrototype Clone();
}

public class ProductModel : IPrototype
{
    public string Name { get; set; }

    public ProductModel(string name)
    {
        Name = name;
    }

    public IPrototype Clone()
    {
        // Create a shallow copy
        return (IPrototype)this.MemberwiseClone();
    }
    
}

public class CategoryModel : IPrototype
{
    public int Type { get; set; }

    public CategoryModel(int value)
    {
        Type = value;
    }

    public IPrototype Clone()
    {
        // Create a shallow copy
        return (IPrototype)this.MemberwiseClone();
    }
    
}


