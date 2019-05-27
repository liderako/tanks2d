using System.Collections;
using System.Collections.Generic;
using PlayableObjects;
using UnityEngine;

public class Kamikaze : Enemy
{
    [SerializeField] private float _damage;
    
    private IState _state;

    private Component _currentState;
    
    void Update()
    {
        if (_state != null && !GameManager.gm.isEnd)
        {
            _state.UpdateState();
        }
    }

    public void StartHunt(Transform targetPlayer)
    {
        var h = gameObject.AddComponent<EnemyStateHunt>();
        h.StateHunt(gameObject, targetPlayer, _damage);
        _currentState = h;
        _state = h;
    }

    public void DeleteOldState()
    {
        _state = null;
        Destroy(_currentState);
    }
}
