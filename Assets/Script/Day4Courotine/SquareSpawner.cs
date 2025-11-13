using System.Collections;
using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
    public GameObject SpawnObject;
    public bool sedangSpawn = true;
    void Start()
    {
        StartCoroutine(MemunculkanObjek());
    }
    IEnumerator MemunculkanObjek()
    {
        while (sedangSpawn == true)
        {
            // Spawn Objeck
            Instantiate(SpawnObject, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5),0), Quaternion.identity);
            // Delay 5 Detik
            yield return new WaitForSeconds(5);
        }
    }
}
