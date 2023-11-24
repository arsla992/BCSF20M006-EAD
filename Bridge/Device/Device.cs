using Bridge;
using System;

// Abstraction
public abstract class RemoteControl
{
    protected IDevice device;

    public RemoteControl(IDevice device)
    {
        this.device = device;
    }

    public abstract void TurnOn();
    public abstract void TurnOff();
}

public class TV : IDevice
{
    public void PowerOn()
    {
        Console.WriteLine("TV is powered on");
    }

    public void PowerOff()
    {
        Console.WriteLine("TV is powered off");
    }
}

public class DVDPlayer : IDevice
{
    public void PowerOn()
    {
        Console.WriteLine("DVD Player is powered on");
    }

    public void PowerOff()
    {
        Console.WriteLine("DVD Player is powered off");
    }
}

// Refined Abstraction - BasicRemote
public class BasicRemote : RemoteControl
{
    public BasicRemote(IDevice device) : base(device) { }

    public override void TurnOn()
    {
        Console.Write("Turning on the device: ");
        device.PowerOn();
    }

    public override void TurnOff()
    {
        Console.Write("Turning off the device: ");
        device.PowerOff();
    }
}

public class Device
{
    public static void Main(string[] args)
    {
        // Operate different electronic devices with a remote control
        IDevice tvDevice = new TV();
        IDevice dvdDevice = new DVDPlayer();

        RemoteControl basicRemoteForTV = new BasicRemote(tvDevice);
        RemoteControl basicRemoteForDVD = new BasicRemote(dvdDevice);

        basicRemoteForTV.TurnOn();
        basicRemoteForTV.TurnOff();

        basicRemoteForDVD.TurnOn();
        basicRemoteForDVD.TurnOff();
    }
}

