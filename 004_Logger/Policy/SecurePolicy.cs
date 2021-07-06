using System;

namespace NapilnikTask_Logger
{
    public class SecurePolicy : ILoggerPolicy
    {
        public bool CanWrite()
        {
            return DateTime.Now.DayOfWeek == DayOfWeek.Friday;
        }
    }
}
