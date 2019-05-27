using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace PlayableObjects
{
    public class EnemyStateHunt : MonoBehaviour, IState
    {
        private Transform _transformTarget;
        private GameObject _owner;
        private float _damage;

        public void StateHunt(GameObject owner, Transform transformPlayer, float damage)
        {
            _owner = owner;
            _transformTarget = transformPlayer;
            _damage = damage;
        }
        
        public void UpdateState()
        {
            _owner.SendMessage("Move", _transformTarget.position);
        }
        
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.GetComponent<Player>() != null)
            {
                other.gameObject.SendMessage("GetHit", _damage);
                _owner.SendMessage("Dead");
            }
        }
    }
}
