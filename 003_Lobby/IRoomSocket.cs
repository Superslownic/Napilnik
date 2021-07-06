namespace NapilnikTask_Lobby
{
    public interface IRoomSocket
    {
        Room Connect(IReadOnlyPlayer player);
        void Disconnect(IReadOnlyPlayer player);
    }
}
