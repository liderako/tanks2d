using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayableObjects;
using Weapons;

namespace InputGame
{
    public class PlayerHandlerInput : MonoBehaviour, IHandlerInput
    {
        private ICommand _buttonX, _buttonQ, _buttonW, _buttonArrowUp,
            _buttonArrowDown, _buttonArrowRight, _buttonArrowLeft;

        [SerializeField] private float _angleRotationUp;
        [SerializeField] private float _angleRotationDown;
        [SerializeField] private float _angleRotationRight;
        [SerializeField] private float _angleRotationLeft;
        [SerializeField] private Weapon _mainWeapon;
        [SerializeField] private Weapon _subWeapon;
        
        public void Start()
        {
            _buttonX = new FireCommand();
            _buttonArrowUp = new MoveCommand(new TankState(gameObject, _angleRotationUp, Vector2.up));
            _buttonArrowDown = new MoveCommand(new TankState(gameObject, _angleRotationDown, Vector2.down));
            _buttonArrowRight = new MoveCommand(new TankState(gameObject, _angleRotationRight, Vector2.right));
            _buttonArrowLeft = new MoveCommand(new TankState(gameObject, _angleRotationLeft, Vector2.left));
            _buttonQ = new ChangingWeaponCommand(_mainWeapon);
            _buttonW = new ChangingWeaponCommand(_subWeapon);
        }

        public void Update()
        {
            HandleInput();    
        }

        public void HandleInput()
        {
            if (Input.GetKey(KeyCode.X))
            {
                _buttonX.Execute(gameObject);
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                _buttonQ.Execute(gameObject);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                _buttonW.Execute(gameObject);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                _buttonArrowUp.Execute(gameObject);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                _buttonArrowDown.Execute(gameObject);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                _buttonArrowRight.Execute(gameObject);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                _buttonArrowLeft.Execute(gameObject);
            }
        }
    }
}
