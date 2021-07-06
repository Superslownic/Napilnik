namespace NapilnikTask3
{
    public interface IRoomSocket
    {
        Room Connect(IReadOnlyPlayer player);
        void Disconnect(IReadOnlyPlayer player);
    }
}
