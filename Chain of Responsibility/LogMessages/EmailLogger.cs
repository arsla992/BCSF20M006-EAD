using ChainOfResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class EmailLogger : ILogHandler
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
}
