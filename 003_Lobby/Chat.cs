using System.Collections.Generic;

namespace NapilnikTask3
{
    public class Chat
    {
        private Queue<Message> _messages;
        private readonly int _maxMessageCount;

        public Chat(int maxMessageCount)
        {
            _messages = new Queue<Message>();
            _maxMessageCount = maxMessageCount;
        }

        public void SendMessage(IReadOnlyPlayer sender, string text)
        {
            var message = new Message(sender.Name, text);
            if (_messages.Count >= _maxMessageCount)
                _messages.Dequeue();
            _messages.Enqueue(message);
        }
    }
}
