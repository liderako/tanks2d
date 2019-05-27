using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    
    public List<FactoryEnemyGameObject> factory;
    
    [SerializeField] private int _maxAmountEnemy;
    [SerializeField] private Transform _transformPlayer;
    [SerializeField] private GameObject _gameOverPanel;
    
    [ReadOnly]private int _currentAmountEnemy;
    private bool _isEnd;
    
    public bool isEnd
    {
        get { return _isEnd; }
    }
    
    void Awake()
    {
        if (gm == null)
        {
            gm = this;
        }
    }

    private void Update()
    {
        if (_isEnd)
        {
            _gameOverPanel.SetActive(true);
            Destroy(this);
        }
        else if (_currentAmountEnemy != _maxAmountEnemy)
        {
            int n = Random.Range(0, factory.Count);
            factory[n].newEnemy(factory[n].RandomNumberEnemy(), _transformPlayer);
            _currentAmountEnemy += 1;
        }    
    }

    public void DeadEnemy()
    {
        _currentAmountEnemy -= 1;
    }

    public void DeadPlayer()
    {
        _isEnd = true;
    }
}
