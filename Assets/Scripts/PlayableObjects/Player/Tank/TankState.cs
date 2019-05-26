using UnityEngine;

namespace PlayableObjects
{
    public class TankState : IState
    {
        private float _angleRotationZ;
        private GameObject _owner;
        private Vector3 _dir;

        public TankState(GameObject owner, float angleRotationZ, Vector3 dir)
        {
            _angleRotationZ = angleRotationZ;
            _owner = owner;
            _dir = dir;
        }

        public void UpdateState()
        {
            _owner.transform.rotation = Quaternion.Euler(0.0f, 0.0f, _angleRotationZ);
            _owner.SendMessage("Move", _dir);
        }

        public Vector3 dir
        {
            get { return _dir; }
        }
    }
}