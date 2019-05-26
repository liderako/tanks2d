using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapons;

namespace PlayableObjects
{
    public class Tank : Player
    {
        [SerializeField]private List<Weapon> _weapons;
        private Weapon _currentWeapon;
        //private PlayerHandlerInput _inputHandler;
        public override void Attack()
        {
            Debug.Log("Attack Player");
            // some code to Attack
        }

        public override void ChangeWeapon(Weapon weapon)
        {
            Debug.Log("Change Weapon");
            // some code to change weapon
        }

        public override void Move(Vector2 dir)
        {
            Debug.Log("Move");
            // some code to move   
        }
    }
}
