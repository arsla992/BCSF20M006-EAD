using System;
using AdapterDesignPattren;

public class LegacyLogger
{
    public void LogMessage(string legacyMessage)
    {
        Console.WriteLine($"LegacyLogger: {legacyMessage}");
    }
}

// Adapter class that adapts LegacyLogger
public class LegacyLoggerAdapter : ILogger
{
    private readonly LegacyLogger legacyLogger;

    public LegacyLoggerAdapter(LegacyLogger legacyLogger)
    {
        this.legacyLogger = legacyLogger;
    }

    public void Log(string message)
    {
        legacyLogger.LogMessage(message);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        LegacyLogger legacyLogger = new LegacyLogger();

        ILogger loggerAdapter = new LegacyLoggerAdapter(legacyLogger);

        loggerAdapter.Log("This is a message using the LegacyLogger through the Adapter");
    }
}
