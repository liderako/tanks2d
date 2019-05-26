using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayableObjects
{
    public class AliveObject : MonoBehaviour, IAliveObject
    {
        [SerializeField] private float _hp;
        [SerializeField] private float _defence;

        public virtual void GetHit(float damage)
        {
            _hp = _hp - damage * (1.0f - _defence);
        }

        public float hp
        {
            get { return _hp; }
            set { _hp = value; }
        }

        public float defence
        {
            get { return _defence; }
            set { _defence = value; }
        }
    }
}