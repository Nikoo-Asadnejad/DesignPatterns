namespace DesignPatterns;

public interface IRequestHandler
{
    void Send();
}

public class RequestHandler : IRequestHandler
{
    public void Send()
    {
        Console.WriteLine("RealSubject: Sending Request.");
    }
}

public class RequestHandlerProxy : IRequestHandler
{
    private RequestHandler _realSubject;
    public void Send()
    {
        if (_realSubject == null)
        {
            _realSubject = new RequestHandler();
        }
        
        //Log Request Here
        Console.WriteLine("Proxy: Logging Request before forwarding to RequestHandler.");
        
        _realSubject.Send();
    }
}

