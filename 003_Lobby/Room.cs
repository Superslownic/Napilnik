using System;
using System.Linq;
using System.Collections.Generic;

namespace NapilnikTask3
{
    public class Room : IRoomSocket
    {
        private List<Cell> _cells;
        private Chat _chat;
        private readonly int _maxReadyPlayers;
        private bool _isPlaying;

        public Room(int maxReadyPlayers)
        {
            _cells = new List<Cell>();
            _chat = new Chat(50);
            _maxReadyPlayers = maxReadyPlayers;
            _isPlaying = false;
        }

        public Room Connect(IReadOnlyPlayer player)
        {
            if (_cells.Exists(cell => cell.Player == player))
                throw new InvalidOperationException();

            if(MaxPlayersReady())
                throw new InvalidOperationException();

            _cells.Add(new Cell(player));
            return this;
        }

        public void Disconnect(IReadOnlyPlayer player)
        {
            Cell cell = _cells.FirstOrDefault(c => c.Player == player);

            if (cell == null)
                return;
            
            _cells.Remove(cell);
        }

        public void SendMessage(IReadOnlyPlayer sender, string text)
        {
            Cell cell = _cells.FirstOrDefault(c => c.Player == sender);

            if (_isPlaying && !cell.IsReady)
                throw new InvalidOperationException();

            _chat.SendMessage(sender, text);
        }

        public void SetReady(IReadOnlyPlayer player, bool value)
        {
            if (_isPlaying)
                throw new InvalidOperationException();

            Cell cell = _cells.FirstOrDefault(c => c.Player == player);

            if (cell.IsReady == value)
                throw new InvalidOperationException();

            cell.IsReady = value;

            _isPlaying = MaxPlayersReady();
        }

        private bool MaxPlayersReady()
        {
            int count = 0;

            foreach (var cell in _cells)
            {
                if (cell.IsReady)
                    count++;
            }

            return count >= _maxReadyPlayers;
        }
    }
}
