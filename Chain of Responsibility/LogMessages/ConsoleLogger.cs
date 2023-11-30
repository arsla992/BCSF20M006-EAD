using ChainOfResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ConsoleLogger : ILogHandler
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
}
