namespace Singleton
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //var invalidLoggerInstant = new Logger();
            var logger1 = Logger.Instance;
            var logger2 = Logger.Instance;
            if (logger2 == logger1)
            {
                logger2.Log("same instance");

            }
        }
    }
} 