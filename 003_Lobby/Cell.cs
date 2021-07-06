namespace NapilnikTask3
{
    public class Cell
    {
        public Cell(IReadOnlyPlayer player)
        {
            Player = player;
            IsReady = false;
        }

        public IReadOnlyPlayer Player { get; private set; }
        public bool IsReady { get; set; }
    }
}
