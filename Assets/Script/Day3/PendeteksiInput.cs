using System;
using UnityEngine;

public class PendeteksiInput : MonoBehaviour
{
   public Action InputEvent;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InputEvent?.Invoke();
        }
    }
}
