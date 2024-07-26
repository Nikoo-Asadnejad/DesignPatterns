namespace DesignPatterns;

public interface IStrategy
{
    void Execute();
}

public class StrategyA : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Strategy A Execution");
    }
}

public class StrategyB : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Strategy B Execution");
    }
}

public class Context
{
    private IStrategy _strategy;

    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecuteStrategy()
    {
        _strategy.Execute();
    }
}

