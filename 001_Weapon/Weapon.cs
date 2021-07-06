using System;

namespace NapilnikTask_Weapon
{
    public class Weapon
    {
        public WeaponParameters Parameters { get; private set; }
        public int Bullets { get; private set; }

        public Weapon(WeaponParameters parameters, int bullets)
        {
            if (bullets < 0)
                throw new ArgumentOutOfRangeException(nameof(bullets));

            Parameters = parameters;
            Bullets = bullets;
        }

        public void AddBullets(int count)
        {
            if(count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            Bullets += count;
        }

        public void Fire(Player player)
        {
            if(Bullets <= 0)
                throw new InvalidOperationException("Out of ammo");
            
            Bullets -= 1;
            player.TakeDamage(Parameters.Damage);
        }
    }
}
