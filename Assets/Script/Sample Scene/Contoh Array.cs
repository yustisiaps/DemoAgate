using UnityEngine;

public class ContohArray : MonoBehaviour
{
    public string[] namaBuah = { "Apel", "Pisang", "Mangga", "Jeruk" };
    void Start()
    {
        Debug.Log(namaBuah[0]);
        namaBuah[0] = "Strawberry";
        Debug.Log(namaBuah[0]); 
        Debug.Log(namaBuah.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
