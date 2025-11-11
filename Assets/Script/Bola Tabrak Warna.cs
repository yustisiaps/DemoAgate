//Bola Tabrak Warna
using UnityEngine;

public class BolaTabrakWarna : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Bola"))
            {
                SpriteRenderer sr = GetComponent<SpriteRenderer>();
                Color warnaAcak = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
                sr.color = warnaAcak;
            }

        }
}
