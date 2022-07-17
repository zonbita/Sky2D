using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualEffect : MonoBehaviour {

    [Tooltip("time destroy")]
    public float destructionTime;

    private void OnEnable()
    {
        StartCoroutine(Destruction()); 
    }

    IEnumerator Destruction() 
    {
        yield return new WaitForSeconds(destructionTime); 
        Destroy(gameObject);
    }
}
