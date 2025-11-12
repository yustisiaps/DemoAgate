using UnityEngine;

public class SpriteMove : MonoBehaviour
{
    public bool moveRight = true;
    public float speed = 5.0f;
    public bool isMoving = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving == true)
        {
            if (moveRight == true)
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }
            else
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
        }else
        {
            //jika tidak bergerak
            transform.transform.Translate(0, 0, 0);
        }
    }
}
