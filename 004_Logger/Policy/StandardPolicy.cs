namespace NapilnikTask_Logger
{
    public class StandardPolicy : ILoggerPolicy
    {
        public bool CanWrite()
        {
            return true;
        }
    }
}
