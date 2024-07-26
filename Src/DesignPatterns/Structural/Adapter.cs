namespace DesignPatterns;

public interface ITarget
{
    string GetRequest();
}

public class Adaptee
{
    public string GetSpecificRequest()
    {
        return "Specific request";
    }
}

public class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public string GetRequest()
    {
        // Translate the request to the adaptee's method
        return $"This is '{_adaptee.GetSpecificRequest()}'";
    }
}
