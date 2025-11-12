using UnityEngine;

public class Score : MonoBehaviour
{
    public PendeteksiInput ObjectPendeteksiInput;
    public int score;
    void OnEnable()
    {
        ObjectPendeteksiInput.InputEvent += Addscore;
    }
    public void Addscore()
    {
        score = score + 1;
    }
    void OnDisable()
    {
        
        ObjectPendeteksiInput.InputEvent -= Addscore;
    }
}
