using System;
using System.Collections;
using System.Collections.Generic;
using PlayableObjects;
using UnityEngine;

namespace Weapons
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField]private GameObject _owner;
        private float _damage;
        private float _speed;
        private float _lifeTime;
        private Vector3 _dir;
        
        //opt
        private Transform _transform;
        
        void Start()
        {
            _transform = transform;
            StartCoroutine(EndLife());
        }
        // Update is called once per frame
        void Update()
        {
            _transform.Translate(_dir * Time.deltaTime * _speed, Space.World);
        }

        public void Fly(Vector3 dir, float damage, float speed, float lifeTime, GameObject owner)
        {
            _dir = dir;
            _damage = damage;
            _speed = speed;
            _owner = owner;
            _lifeTime = lifeTime;
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject != _owner)
            {
                if (other.gameObject.GetComponent<AliveObject>() != null)
                {
                    other.gameObject.SendMessage("GetHit", _damage);
                }
                Destroy(gameObject);
            }
        }

        private IEnumerator EndLife()
        {
            yield return new WaitForSeconds(_lifeTime);
            Destroy(gameObject);
        }
    }
}
