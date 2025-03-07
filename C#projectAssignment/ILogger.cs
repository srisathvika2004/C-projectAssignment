using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_projectAssignment
{
    interface ILogger
    {
        {
    void Log(string message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging to file: {message}");
        }
    }

    // Decorator
    public class TimestampLogger : ILogger
    {
        private readonly ILogger _logger;
        public TimestampLogger(ILogger logger) => _logger = logger;

        public void Log(string message)
        {
            _logger.Log($"[{DateTime.Now}] {message}");
        }
    }

    // Decorator
    public class ErrorLogger : ILogger
    {
        private readonly ILogger _logger;
        public ErrorLogger(ILogger logger) => _logger = logger;

        public void Log(string message)
        {
            _logger.Log($"ERROR: {message}");
        }
    }
}
}
