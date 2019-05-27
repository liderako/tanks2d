using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayableObjects;

namespace InputGame
{
    public class MoveCommand : ICommand
    {
        private IState _state;

        public MoveCommand(IState state)
        {
            _state = state;
        }
        
        public void Execute(GameObject go)
        {
            go.SendMessage("ChangeState", _state);
        }
    }
}
