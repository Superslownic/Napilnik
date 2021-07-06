namespace NapilnikTask_Lobby
{
    public class Player : IReadOnlyPlayer
    {
        private MatchMaker _matchMaker;
        private Room _room;

        public Player(string name, MatchMaker matchMaker)
        {
            _matchMaker = matchMaker;

            Name = name;
        }

        public string Name { get; private set; }
        
        public void ConnectToRoom()
        {
            _room = _matchMaker.AvailableRooms.Any().Connect(this);
        }

        public void ConnectToNewRoom()
        {
            _room = _matchMaker.CreateRoom().Connect(this);
        }

        public void DisconnectFromRoom()
        {
            _room.Disconnect(this);
            _room = null;
        }

        public void SendMessage(string text)
        {
            _room.SendMessage(this, text);
        }

        public void SetReady(bool value)
        {
            _room.SetReady(this, value);
        }
    }
}
