using System.Runtime.CompilerServices;
using System.Collections;
using UnityEngine;

public class ContohCoroutine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(coroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //function Enumerator untuk coroutine
    IEnumerator coroutine()
    {
        Debug.Log("Perintah 1");
        yield return new WaitForSeconds(2);
        Debug.Log("Perintah 2");
    }
}
