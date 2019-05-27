using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryEnemyGameObject: MonoBehaviour
{
    [SerializeField]private List<GameObject> _enemy;

    [SerializeField] private Transform _transform;
    
    public enum TypesEnemy
    {
        Kamikaze = 0,
        KamikazeC = 1,
    };

     public int RandomNumberEnemy()
    {
        return Random.Range(0, _enemy.Count);
    } 

    public GameObject newEnemy(int t, Transform playerTarget)
    {
        GameObject go = Instantiate(_enemy[t], transform);
        if (t == (int)TypesEnemy.Kamikaze)
        {
            go.GetComponent<Kamikaze>().StartHunt(playerTarget);
        }
        else if (t == (int)TypesEnemy.KamikazeC)
        {
            go.GetComponent<Kamikaze>().StartHunt(playerTarget);
        }
        return go;
    }
}
