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

//another sample

// Step 1: Define the Target Interface
public interface ICharger
{
    void ChargeDevice();
}

// Step 2: Create the Adaptee Classes
public class LaptopCharger
{
    public void ChargeLaptop()
    {
        Console.WriteLine("Charging Laptop");
    }
}

public class SmartphoneCharger
{
    public void ChargeSmartphone()
    {
        Console.WriteLine("Charging Smartphone");
    }
}

public class TabletCharger
{
    public void ChargeTablet()
    {
        Console.WriteLine("Charging Tablet");
    }
}

// Step 3: Create the Adapter Classes
public class LaptopChargerAdapter : ICharger
{
    private readonly LaptopCharger _laptopCharger;

    public LaptopChargerAdapter(LaptopCharger laptopCharger)
    {
        _laptopCharger = laptopCharger;
    }

    public void ChargeDevice()
    {
        _laptopCharger.ChargeLaptop();
    }
}

public class SmartphoneChargerAdapter : ICharger
{
    private readonly SmartphoneCharger _smartphoneCharger;

    public SmartphoneChargerAdapter(SmartphoneCharger smartphoneCharger)
    {
        _smartphoneCharger = smartphoneCharger;
    }

    public void ChargeDevice()
    {
        _smartphoneCharger.ChargeSmartphone();
    }
}

public class TabletChargerAdapter : ICharger
{
    private readonly TabletCharger _tabletCharger;

    public TabletChargerAdapter(TabletCharger tabletCharger)
    {
        _tabletCharger = tabletCharger;
    }

    public void ChargeDevice()
    {
        _tabletCharger.ChargeTablet();
    }
}

// Example Usage
public class AdapterSample
{
    public static void Usage(string[] args)
    {
        // Create the adaptees
        var laptopCharger = new LaptopCharger();
        var smartphoneCharger = new SmartphoneCharger();
        var tabletCharger = new TabletCharger();

        // Create the adapters
        ICharger laptopChargerAdapter = new LaptopChargerAdapter(laptopCharger);
        ICharger smartphoneChargerAdapter = new SmartphoneChargerAdapter(smartphoneCharger);
        ICharger tabletChargerAdapter = new TabletChargerAdapter(tabletCharger);

        // Use the adapters to charge different devices
        laptopChargerAdapter.ChargeDevice();
        smartphoneChargerAdapter.ChargeDevice();
        tabletChargerAdapter.ChargeDevice();
    }
}