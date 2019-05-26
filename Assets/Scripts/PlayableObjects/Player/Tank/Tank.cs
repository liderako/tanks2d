using System.Collections.Generic;
using UnityEngine;
using Weapons;

namespace PlayableObjects
{
    public class Tank : Player
    {
        [SerializeField] private GameObject _mainWeapon;
        [SerializeField] private GameObject _subWeapon;
        private Weapon _currentWeapon;
        private TankState _state;

        void Start()
        {
            _state = new TankState(gameObject, 0, Vector2.up);
            _currentWeapon = _mainWeapon.GetComponent<Weapon>();
            // optimization
            _transform = transform;
        }
        
        public override void Attack()
        {
            _currentWeapon.Attack(_state.dir);
        }

        public override void ChangeWeapon(Weapon weapon)
        {
            if (_mainWeapon.GetComponent<Weapon>() == weapon)
            {
                _subWeapon.SetActive(false);
                _mainWeapon.SetActive(true);
            }
            else
            {
                _mainWeapon.SetActive(false);
                _subWeapon.SetActive(true);
            }
            _currentWeapon = weapon;
        }

        public void ChangeState(TankState state)
        {
            _state = state;
            _state.UpdateState();
        }
    }
}
