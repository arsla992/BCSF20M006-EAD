using System;

public class ComputerSystemFacade
{
    private Bios bios;
    private OperatingSystem os;

    public ComputerSystemFacade()
    {
        bios = new Bios();
        os = new OperatingSystem();
    }

    public void StartComputer()
    {
        Console.WriteLine("Starting computer...");
        bios.PowerOn();
        bios.InitializeHardware();
        os.Load();
    }
}

// Subsystem - BIOS
public class Bios
{
    public void PowerOn()
    {
        Console.WriteLine("Powering on BIOS...");
    }

    public void InitializeHardware()
    {
        Console.WriteLine("Initializing hardware...");
    }
}

// Subsystem - OperatingSystem
public class OperatingSystem
{
    public void Load()
    {
        Console.WriteLine("Loading operating system...");
    }
}

public class ComputerBIOS
{
    public static void Main(string[] args)
    {
        // Using the ComputerSystemFacade to simplify interaction with computer hardware
        ComputerSystemFacade computerFacade = new ComputerSystemFacade();
        computerFacade.StartComputer();
    }
}
