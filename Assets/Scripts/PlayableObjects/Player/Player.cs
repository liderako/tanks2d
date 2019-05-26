using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapons;

namespace PlayableObjects
{
    public class Player : AliveObject, IMovingObject, IChanginWeapon, IAttackingObject
    {
        [SerializeField]private float _speed;

        public float speed 
        {
            get {return _speed;}
            set {_speed = value;}
        }

        public virtual void Move(Vector2 dir) 
        {
            // default move, nothing.
        }

        public virtual void ChangeWeapon(Weapon weapon)
        {
            // default change weapon, nothing.
        }

        public virtual void Attack() 
        {
            // default attack, nothing.
        }
    }
}