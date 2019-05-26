namespace PlayableObjects
{
    public interface IAliveObject
    {
        void GetHit(float damage);

        float hp { get; set; }
        float defence { get; set; }
    }
}