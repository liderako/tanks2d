namespace PlayableObjects
{
    public interface IAliveObject
    {
        void GetHit(float damage);
        void Dead();

        float hp { get; set; }
        float defence { get; set; }
    }
}