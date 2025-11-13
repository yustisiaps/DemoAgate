using UnityEngine;

public class SquareMouse : MonoBehaviour
{
    public Transform cubeTransform;
    public  Vector2 Posisiklik;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {   
        //Geser Mouse
        // Vertor2 worldmousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // cubeTransform.position = Vector2.MoveTowards<cubeTrasform.position.worldmousePosition>;
        //Geser Object ke click
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Posisiklik = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        cubeTransform.position = Vector2.MoveTowards(cubeTransform.position,Posisiklik,0.0001f);
    }
}
