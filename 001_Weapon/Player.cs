using System;

namespace NapilnikTask1
{
    public class Player
    {
        public int Health { get; private set; }
        
        public Player(int health)
        {
            Health = health;
        }

        public bool IsAlive => Health > 0;

        public void Heal(int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            Health += count;
        }

        public void TakeDamage(int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            
            Health -= count;
        }
    }
}
