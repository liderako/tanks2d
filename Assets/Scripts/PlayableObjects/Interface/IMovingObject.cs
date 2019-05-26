using UnityEngine;

namespace PlayableObjects
{
    public interface IMovingObject
    {
        float speed { get; set; }
        void Move(Vector3 dir);
    }
}
