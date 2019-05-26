using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapons;

namespace InputGame {
    public class ChangingWeaponCommand  : ICommand
    {
        private Weapon _weapon;

        public ChangingWeaponCommand(Weapon weapon)
        {
            _weapon = weapon;
        }
        
        public void Execute(GameObject go)
        {
            go.SendMessage("ChangeWeapon", _weapon);
        }
    }
}
