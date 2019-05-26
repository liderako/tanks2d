using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapons
{
    public class Bullet : MonoBehaviour
    {
        private GameObject _owner;
        private float _damage;
        private float _speed;
        private Vector3 _dir;
        
        //opt
        private Transform _transform;
        
        void Start()
        {
            _transform = transform;
        }
        // Update is called once per frame
        void Update()
        {
            _transform.Translate(_dir * Time.deltaTime * _speed, Space.World);
        }

        public void Fly(Vector3 dir, float damage, float speed, GameObject owner)
        {
            _dir = dir;
            _damage = damage;
            _speed = speed;
            _owner = owner;
        }
    }
}
