using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapons
{
    public class Weapon : MonoBehaviour, IWeapon
    {
        [SerializeField] private float _damage;
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

        public void Attack()
        {
            // spawn bullet
        }
    }
}
