using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapons;

namespace PlayableObjects
{
    public class Player : AliveObject, IMovingObject, IChanginWeapon, IAttackingObject
    {
        [SerializeField]protected float _speed;
        
        // optimization
        protected Transform _transform;
        
        void Start()
        {
            _transform = transform;
        }
        
        public float speed 
        {
            get {return _speed;}
            set {_speed = value;}
        }

        public virtual void Move(Vector3 dir) 
        {
            _transform.Translate(dir * Time.deltaTime * _speed, Space.World);
        }

        public virtual void ChangeWeapon(Weapon weapon)
        {
            // default change weapon, nothing.
        }

        public virtual void Attack() 
        {
            // default attack, nothing.
        }

        public override void Dead()
        {
            base.Dead();
            GameManager.gm.SendMessage("DeadPlayer");
        }
    }
}