using ChainOfResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
   public class FileLogger : ILogHandler
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
}
