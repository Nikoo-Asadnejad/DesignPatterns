namespace DesignPatterns;

using System;
using System.Collections.Generic;

public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}

public interface IObserver
{
    void Update(ISubject subject);
}

public class Stock : ISubject
{
    private List<IObserver> _observers = new();
    private string _name;
    private decimal _price;

    public Stock(string name, decimal price)
    {
        _name = name;
        _price = price;
    }

    public string Name
    {
        get { return _name; }
    }

    public decimal Price
    {
        get { return _price; }
        set
        {
            _price = value;
            Notify();
        }
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }
}

public class Investor : IObserver
{
    private string _name;

    public Investor(string name)
    {
        _name = name;
    }

    public void Update(ISubject subject)
    {
        if (subject is Stock stock)
        {
            Console.WriteLine($"Investor {_name} notified: {stock.Name} stock price changed to {stock.Price}");
        }
    }
}

class ObserverSample
{
    static void Usage()
    {
        // Create a stock and investors
        Stock googleStock = new Stock("Google", 1000m);
        Investor investor1 = new Investor("Alice");
        Investor investor2 = new Investor("Bob");

        // Attach investors to the stock
        googleStock.Attach(investor1);
        googleStock.Attach(investor2);

        // Change the stock price and see notifications
        googleStock.Price = 1200m;
        googleStock.Price = 1300m;

        // Detach an investor and change the stock price again
        googleStock.Detach(investor1);
        googleStock.Price = 1400m;
    }
}