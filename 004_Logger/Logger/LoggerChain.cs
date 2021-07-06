using System.Collections.Generic;

namespace NapilnikTask_Logger
{
    public class LoggerChain : ILogger
    {
        private IEnumerable<ILogger> _loggers;

        public LoggerChain(params ILogger[] loggers)
        {
            _loggers = loggers;
        }

        public void WriteError(string message)
        {
            foreach (var logger in _loggers)
                logger.WriteError(message);
        }
    }
}
