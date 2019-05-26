using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InputGame
{
    public class FireCommand : ICommand
    {
        public void Execute(GameObject go)
        {
            go.SendMessage("Attack");
        }
    }
}
