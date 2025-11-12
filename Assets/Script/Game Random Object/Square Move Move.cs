using UnityEngine;

public class SquareMoveMove : MonoBehaviour
{
    public ArahGerakB arahGerakB = ArahGerakB.Kanan;

    public Interaksi12B interaksi12B;
    public float speed = 5.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (arahGerakB)
        {
            case ArahGerakB.Kiri:
                transform.Translate(-speed * Time.deltaTime, 0, 0);
                break;
            case ArahGerakB.Kanan:
                transform.Translate(speed * Time.deltaTime, 0, 0);
                break;
            case ArahGerakB.Atas:
                transform.Translate(0, speed * Time.deltaTime, 0);
                break;
            case ArahGerakB.Bawah:
                transform.Translate(0, -speed * Time.deltaTime, 0);
                break;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dinding"))
        {
            Debug.Log("Bertabrakan dengan dinding");
            if (arahGerakB == ArahGerakB.Kanan)
            {
                arahGerakB = ArahGerakB.Kiri;
            }
            else if (arahGerakB == ArahGerakB.Kiri)
            {
                arahGerakB = ArahGerakB.Kanan;
            }
            else if (arahGerakB == ArahGerakB.Atas)
            {
                arahGerakB = ArahGerakB.Bawah;
            }
            else if (arahGerakB == ArahGerakB.Bawah)
            {
                arahGerakB = ArahGerakB.Atas;
            }
        }

    }
    
    public void TambahSkor
    
}
public enum ArahGerakB
    {
        Kiri,
        Kanan,
        Atas,
        Bawah
    }