using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InputGame
{
    interface ICommand
    {
        void Execute(GameObject gameObject);
    }
}