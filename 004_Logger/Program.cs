using System;

namespace NapilnikTask_Logger
{
    public class Program
    {
        static void Main(string[] args)
        {
            var standardPolicy = new StandardPolicy();
            var securePolicy = new SecurePolicy();

            var standardFileLogger = new FileLogger(standardPolicy);
            var standardConsoleLogger = new ConsoleLogger(standardPolicy);

            var secureFileLogger = new FileLogger(securePolicy);
            var secureConsoleLogger = new ConsoleLogger(securePolicy);

            var loggerChain = new LoggerChain(standardConsoleLogger, secureFileLogger);

            var pathfinder1 = new Pathfinder(standardFileLogger);
            var pathfinder2 = new Pathfinder(standardConsoleLogger);
            var pathfinder3 = new Pathfinder(secureFileLogger);
            var pathfinder4 = new Pathfinder(secureConsoleLogger);
            var pathfinder5 = new Pathfinder(loggerChain);

            pathfinder1.Find();
            pathfinder2.Find();
            pathfinder3.Find();
            pathfinder4.Find();
            pathfinder5.Find();

            Console.ReadKey();
        }
    }
}
