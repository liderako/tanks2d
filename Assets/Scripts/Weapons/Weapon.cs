using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapons
{
    public class Weapon : MonoBehaviour, IWeapon
    {
        [SerializeField] private float _damage;
        [SerializeField] private float _speedFlyBullet;
        [SerializeField] private float _coolDown;
        [SerializeField] private GameObject bullet;
        
        public float damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        
        public float coolDown
        {
            get { return _coolDown; }
            set { _coolDown = value; }
        }

        public void Attack(Vector3 dir)
        {
            GameObject go = Instantiate(bullet, transform);
            go.transform.Rotate(0, 0, transform.parent.transform.eulerAngles.z);
            go.GetComponent<Bullet>().Fly(dir, _damage, _speedFlyBullet, gameObject);
        }
    }
}
