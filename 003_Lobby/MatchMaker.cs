using System.Collections.Generic;

namespace NapilnikTask3
{
    public class MatchMaker
    {
        private List<Room> _rooms;

        public MatchMaker()
        {
            _rooms = new List<Room>();
        }

        public IReadOnlyList<IRoomSocket> AvailableRooms => _rooms;
        
        public IRoomSocket CreateRoom()
        {
            var room = new Room(2);
            _rooms.Add(room);
            return room;
        }
    }
}
