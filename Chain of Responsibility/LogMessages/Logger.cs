using System;

// Handler Interface
interface ILogHandler
{
    void HandleLog(string message, LogLevel logLevel);
}

// Enum for LogLevel
enum LogLevel
{
    Info,
    Warning,
    Error
}


// FileLogger class
class FileLogger : ILogHandler
{
    public void HandleLog(string message, LogLevel logLevel)
    {
        if (logLevel == LogLevel.Warning)
        {
            // Logic to log to a file for warnings
            Console.WriteLine($"Warning logged to file: {message}");
        }
        else if (NextHandler != null)
        {
            NextHandler.HandleLog(message, logLevel);
        }
    }

    public ILogHandler NextHandler { get; set; }
}

// EmailLogger class
class EmailLogger : ILogHandler
{
    public void HandleLog(string message, LogLevel logLevel)
    {
        if (logLevel == LogLevel.Error)
        {
            // Logic to send an email for errors
            Console.WriteLine($"Error email sent: {message}");
        }
        else if (NextHandler != null)
        {
            NextHandler.HandleLog(message, logLevel);
        }
    }

    public ILogHandler NextHandler { get; set; }
}



// Concrete Handler
class ConsoleLogger : ILogHandler
{
    public void HandleLog(string message, LogLevel logLevel)
    {
        if (logLevel == LogLevel.Info)
        {
            Console.WriteLine($"Info: {message}");
        }
        else if (NextHandler != null)
        {
            NextHandler.HandleLog(message, logLevel);
        }
    }

    public ILogHandler NextHandler { get; set; }
}

// Request Class
class LogMessage
{
    public string Message { get; }
    public LogLevel LogLevel { get; }

    public LogMessage(string message, LogLevel logLevel)
    {
        Message = message;
        LogLevel = logLevel;
    }
}

class Program
{
    static void Main()
    {
        // Creating a chain of loggers
        ConsoleLogger consoleLogger = new ConsoleLogger();
        FileLogger fileLogger = new FileLogger();
        EmailLogger emailLogger = new EmailLogger();

        consoleLogger.NextHandler = fileLogger;
        fileLogger.NextHandler = emailLogger;

        // Handling log messages
        LogMessage logMessage1 = new LogMessage("This is an informational message", LogLevel.Info);
        LogMessage logMessage2 = new LogMessage("Warning: Potential issue detected", LogLevel.Warning);
        LogMessage logMessage3 = new LogMessage("Error: Critical error occurred", LogLevel.Error);

        consoleLogger.HandleLog(logMessage1.Message, logMessage1.LogLevel);
        consoleLogger.HandleLog(logMessage2.Message, logMessage2.LogLevel);
        consoleLogger.HandleLog(logMessage3.Message, logMessage3.LogLevel);
    }
}
