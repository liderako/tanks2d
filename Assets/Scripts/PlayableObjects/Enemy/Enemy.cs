using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayableObjects
{
    public abstract class Enemy : AliveObject, IMovingObject
    {
        [SerializeField] private float _speed;


        public virtual void Move(Vector3 position)
        {
            transform.position = Vector3.MoveTowards(transform.position, position, speed);
        }
        
        public float speed 
        {
            get {return _speed;}
            set {_speed = value;}
        }

        public override void Dead()
        {
            base.Dead();
            GameManager.gm.SendMessage("DeadEnemy");
        }
    }
}