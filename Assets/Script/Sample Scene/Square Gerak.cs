using UnityEngine;

public class SquareGerak : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Game object letak dimana script ini dipasang
        gameObject.transform.Translate(5*Time.deltaTime, 0, 0);
    }
}
