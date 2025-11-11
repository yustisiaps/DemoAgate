using UnityEngine;

public class diamondwarna : MonoBehaviour
{
        SpriteRenderer sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // sr = GetComponent<SpriteRenderer>();
        // sr.color = Color.red;
        sr = GetComponent<SpriteRenderer>();
        Color warna;
        ColorUtility.TryParseHtmlString("#00FF00", out warna);
        sr.color = warna;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
