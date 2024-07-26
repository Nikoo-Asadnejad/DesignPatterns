namespace DesignPatterns;

/// <summary>
/// Only one object can be created from this class
/// You can add your properties thi this class
/// </summary>
public sealed class Singleton
{
    // Private constructor ensures that an object is not instantiated from outside the class.
    private Singleton()
    {
    }

    // This holds the single instance of the class and will be created only when it is needed and in a thread-safe manner.
    private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

    // This will get the instance of the class.
    public static Singleton Instance
    {
        get
        {
            return instance.Value;
        }
    }

}

