using System.IO;

namespace NapilnikTask_Logger
{
    public class FileLogger : BaseLogger
    {
        public FileLogger(ILoggerPolicy policy) : base(policy)
        {
        }

        protected override void WriteMethod(string message)
        {
            File.WriteAllText("log.txt", message);
        }
    }
}
