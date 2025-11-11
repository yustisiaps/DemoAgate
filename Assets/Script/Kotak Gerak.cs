//KotakGerak
using Unity.VisualScripting;
using UnityEngine;

public class KotakGerak : MonoBehaviour
{
    public float speed = 0.0f;
    public bool moveRight = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight)
        {
            gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else
        {
            gameObject.transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Kotak bertabrakan");
        if (moveRight)
        {
            moveRight = false;
        }
        else
        {
            moveRight = true;
        }
    }
}
