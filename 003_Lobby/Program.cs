namespace NapilnikTask3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var matchMaker = new MatchMaker();

            var player1 = new Player("player1", matchMaker);
            var player2 = new Player("player2", matchMaker);
            var player3 = new Player("player3", matchMaker);
            var player4 = new Player("player4", matchMaker);

            player1.ConnectToNewRoom();
            player2.ConnectToRoom();
            player3.ConnectToRoom();

            player1.SendMessage("Hello");
            player2.SendMessage("Hi");

            player1.SetReady(true);
            player2.SetReady(true);

            player1.SendMessage("GG");
            player3.SendMessage("Hi"); //InvalidOperationException

            player4.ConnectToRoom(); //InvalidOperationException
        }
    }
}
