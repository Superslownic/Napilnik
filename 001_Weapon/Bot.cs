namespace NapilnikTask1
{
    public class Bot
    {
        public Weapon Weapon { get; private set; }

        public Bot(Weapon weapon)
        {
            Weapon = weapon;
        }

        public void OnSeePlayer(Player player)
        {
            if(player.IsAlive)
                Weapon.Fire(player);
        }
    }
}
