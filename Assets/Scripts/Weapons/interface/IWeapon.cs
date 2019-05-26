namespace Weapons
{
    public interface IWeapon
    {
        float damage
        {
            get;
            set;
        }
        
        float coolDown
        {
            get;
            set;
        }

        void Attack();
    }
}
