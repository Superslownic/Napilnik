namespace NapilnikTask_Weapon
{
    public class WeaponParameters
    {
        public int Damage { get; private set; }

        public WeaponParameters(int damage)
        {
            Damage = damage;
        }
    }
}
