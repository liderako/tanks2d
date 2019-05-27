using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapons
{
    public class Weapon : MonoBehaviour, IWeapon
    {
        [SerializeField] private float _damage;
        [SerializeField] private float _speedFlyBullet;
        [SerializeField] private float _coolDown;
        [SerializeField] private float _lifeTimeBullet;
        [SerializeField] private GameObject _bullet;
        [SerializeField] private Transform _transformSpawnBullet;
        [SerializeField] private AudioSource _soundAttack;
        private bool _isReady = true;
        
        public float damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        
        public float coolDown
        {
            get { return _coolDown; }
            set { _coolDown = value; }
        }

        public void Attack(Vector3 dir)
        {
            if (!_isReady)
            {
                return;
            }
            GameObject go = Instantiate(_bullet);
            go.transform.Rotate(0, 0, transform.parent.transform.eulerAngles.z);
            go.transform.position = _transformSpawnBullet.position;
            go.transform.SetParent(transform.parent.transform.parent, false);
            go.GetComponent<Bullet>().Fly(dir, _damage, _speedFlyBullet, _lifeTimeBullet, transform.parent.gameObject);
            go.SetActive(true);
            _soundAttack.Play();
            _isReady = false;
            StartCoroutine(coolDownWeapon());
        }
        
        IEnumerator coolDownWeapon()
        {
            yield return new WaitForSeconds(_coolDown);
            _isReady = true;
        }
    }
}
