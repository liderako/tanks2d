using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _secondsWaint;
    [SerializeField] private float _size; // 0-1
    
    void Start()
    {
        StartCoroutine(AnimationStart());
    }

    IEnumerator AnimationStart()
    {
        Vector3 tmp = transform.localScale;
        transform.localScale = new Vector3(tmp.x * _size, tmp.y * _size, 1);
        yield return new WaitForSeconds(_secondsWaint);
        transform.localScale = tmp;
    }
}
