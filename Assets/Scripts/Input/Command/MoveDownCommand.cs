using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InputGame
{
    public class MoveDownCommand : ICommand
    {
        public void Execute(GameObject go)
        {
                  go.SendMessage("Move");
        }
    }
}