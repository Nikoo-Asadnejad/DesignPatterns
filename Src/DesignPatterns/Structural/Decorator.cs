namespace DesignPatterns;


public interface IRepository
{
    string Get();
}

public class Repository : IRepository
{
    public string Get()
    {
        return "ConcreteComponent";
    }
}

public abstract class RepositoryCacheDecorator : IRepository
{
    protected IRepository _repository;

    public RepositoryCacheDecorator(IRepository repository )
    {
        _repository = repository;
    }

    public virtual string Get()
    {
        //exist in cache return
       
        //else
        return _repository.Get();
    }
}





