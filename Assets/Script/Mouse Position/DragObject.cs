using System.Numerics;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    // void OnMouseEnter()
    // {
    //     Debug.Log("Enter");
    // }
    // void OnMouseDown()
    // {
    //     Debug.Log("Down");
    // }
    // void OnMouseDrag()
    // {
    //     Debug.Log("Drag");
    // }
    // void OnMouseExit()
    // {
    //     Debug.Log("Exit");
    // }
    void OnMouseDrag()
    {
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 squarePosition = new Vector2(worldMousePosition.x, transform.position.y);
        Vector2 minimum = Camera.main.ScreenToWorldPoint(new Vector(0,0,0));
        Vector2 maximum = Camera.main.ScreenToWorldPoint(new Vector(Screen.width,0,0));
        squarePosition.x = Mathf.Clamp(squarePosition.x, minimum, maximum);
        transform.position = squarePosition;
    }
}
