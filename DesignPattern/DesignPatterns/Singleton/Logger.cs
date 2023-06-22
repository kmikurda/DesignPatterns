using System;

namespace Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger
    {
        private static readonly Lazy<Logger> _logger = new Lazy<Logger>(() => new Logger()); //thread-safe way to init Singleton only once when first call occured
        public static Logger Instance => _logger.Value;

        protected Logger()
        {
            
        }

        public void Log(string Message)
        {
            Console.WriteLine($"Message: {Message}");
        }
    }
}