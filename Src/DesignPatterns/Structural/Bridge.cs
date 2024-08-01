namespace DesignPatterns;

public interface IDevice
{
    void On();
    void Off();
    void SetVolume(int percent);
}
public class TV : IDevice
{
    public void On()
    {
        Console.WriteLine("TV is On");
    }

    public void Off()
    {
        Console.WriteLine("TV is Off");
    }

    public void SetVolume(int percent)
    {
        Console.WriteLine($"TV Volume set to {percent}%");
    }
}
public class Radio : IDevice
{
    public void On()
    {
        Console.WriteLine("Radio is On");
    }

    public void Off()
    {
        Console.WriteLine("Radio is Off");
    }

    public void SetVolume(int percent)
    {
        Console.WriteLine($"Radio Volume set to {percent}%");
    }
}
public abstract class RemoteControl
{
    protected IDevice device;

    protected RemoteControl(IDevice device)
    {
        this.device = device;
    }

    public abstract void TurnOn();
    public abstract void TurnOff();
    public abstract void SetVolume(int percent);
}
public class AdvancedRemoteControl : RemoteControl
{
    public AdvancedRemoteControl(IDevice device) : base(device) {}

    public override void TurnOn()
    {
        device.On();
    }

    public override void TurnOff()
    {
        device.On();
    }

    public override void SetVolume(int percent)
    {
        device.SetVolume(percent);
    }

    public void Mute()
    {
        device.SetVolume(0);
        Console.WriteLine("Device muted");
    }
}
public class Bridge
{
    public void SampleUsage()
    {
        RemoteControl remoteControl = new AdvancedRemoteControl(new TV());
        remoteControl.TurnOn();
        remoteControl.SetVolume(50);
        remoteControl.TurnOff();

        remoteControl = new AdvancedRemoteControl(new Radio());
        remoteControl.TurnOn();
        remoteControl.SetVolume(75);
        remoteControl.TurnOff();
    }
}