namespace NapilnikTask_Logger
{
    public abstract class BaseLogger : ILogger
    {
        private ILoggerPolicy _policy;

        public BaseLogger(ILoggerPolicy policy)
        {
            _policy = policy;
        }

        public void WriteError(string message)
        {
            if(_policy.CanWrite())
                WriteMethod(message);
        }

        protected abstract void WriteMethod(string message);
    }
}
