namespace DesignPatterns.Creational;

public interface ISupplierServiceA
{
    string GetName();
}

public interface ISupplierServiceB
{
    string GetDescription();
}

public class SupplierServiceASoap : ISupplierServiceA
{
    public string GetName()
    {
        return "ConcreteProductA1";
    }
}

public class SupplierServiceARest : ISupplierServiceA
{
    public string GetName()
    {
        return "ConcreteProductA2";
    }
}

public class SupplierServiceBSoap : ISupplierServiceB
{
    public string GetDescription()
    {
        return "Description of ConcreteProductB1";
    }
}

public class SupplierServiceBRest : ISupplierServiceB
{
    public string GetDescription()
    {
        return "Description of ConcreteProductB2";
    }
}

public interface ISupplierFactory
{
    ISupplierServiceA CreateSupplierServiceA();
    ISupplierServiceB CreateSupplierServiceB();
}

public sealed class SoapSupplierFactory : ISupplierFactory
{
    public ISupplierServiceA CreateSupplierServiceA()
    {
        return new SupplierServiceASoap();
    }

    public ISupplierServiceB CreateSupplierServiceB()
    {
        return new SupplierServiceBSoap();
    }
}

public class RestSupplierFactory : ISupplierFactory
{
    public ISupplierServiceA CreateSupplierServiceA()
    {
        return new SupplierServiceARest();
    }

    public ISupplierServiceB CreateSupplierServiceB()
    {
        return new SupplierServiceBRest();
    }
}
