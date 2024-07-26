namespace DesignPatterns;

public sealed class SubsystemA
{
    public void OperationA()
    {
        Console.WriteLine("SubsystemA: OperationA");
    }
}

public sealed class SubsystemB
{
    public void OperationB()
    {
        Console.WriteLine("SubsystemB: OperationB");
    }
}

public sealed class SubsystemC
{
    public void OperationC()
    {
        Console.WriteLine("SubsystemC: OperationC");
    }
}

public sealed class Facade
{
    private readonly SubsystemA _subsystemA;
    private readonly SubsystemB _subsystemB;
    private readonly SubsystemC _subsystemC;

    public Facade()
    {
        _subsystemA = new SubsystemA();
        _subsystemB = new SubsystemB();
        _subsystemC = new SubsystemC();
    }

    public void Operation1()
    {
        Console.WriteLine("Facade: Operation1");
        _subsystemA.OperationA();
        _subsystemB.OperationB();
    }

    public void Operation2()
    {
        Console.WriteLine("Facade: Operation2");
        _subsystemB.OperationB();
        _subsystemC.OperationC();
    }
}

