namespace NapilnikTask_Lobby
{
    public class Message
    {
        public string SenderName { get; private set; }
        public string Text { get; private set; }

        public Message(string senderName, string text)
        {
            SenderName = senderName;
            Text = text;
        }
    }
}
