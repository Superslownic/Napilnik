using System;

namespace NapilnikTask_Logger
{
    public class ConsoleLogger : BaseLogger
    {
        public ConsoleLogger(ILoggerPolicy policy) : base(policy)
        {
        }

        protected override void WriteMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
}
