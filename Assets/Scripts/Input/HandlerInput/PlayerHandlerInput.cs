using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InputGame
{
    public class PlayerHandlerInput : MonoBehaviour, IHandlerInput
    {
        //private List<ICommand> _commands;
        private ICommand buttonX;

        public void Start()
        {
            buttonX = new ChangingWeaponCommand();
            // init command and owner
        }

        public void Update()
        {
            HandleInput();    
        }

        public void HandleInput()
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                Debug.Log(KeyCode.X);
                buttonX.Execute(gameObject);
            }
        }
    }
}
