using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class LogMessage
    {
        public string Message { get; }
        public LogLevel LogLevel { get; }

        public LogMessage(string message, LogLevel logLevel)
        {
            Message = message;
            LogLevel = logLevel;
        }
    }
}
