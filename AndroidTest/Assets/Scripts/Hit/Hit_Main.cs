using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Main : MonoBehaviour
{
    void Start()
    {
        StartCoroutine (deactivate ());
    }

    void Update()
    {
        
    }
    
    IEnumerator deactivate()
    {
        yield return new WaitForSeconds(1);
        this.gameObject.SetActive(false);
    }
}
