using TMPro;
using UnityEngine;

public class SquareMoveMove : MonoBehaviour
{
    //Deklarasi variabel arahGerakB dengan tipe data ArahGerakB
    public ArahGerakB arahGerakB = ArahGerakB.Kanan;
    //Deklarasi variabel interaksi12B dengan tipe data Interaksi12B
    public Interaksi12B interaksi12B;
    //deklarasi variabel speed dengan tipe data float untuk mengatur kecepatan gerak objek
    public float speed = 5.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Mengecek arah gerak dan menggerakkan objek sesuai arah yang ditentukan
        switch (arahGerakB)
        {
            // Menentukan gerakan berdasarkan arahGerakB yang dipilih kiri, kanan, atas, atau bawah
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
    //untuk mendeteksi tabrakan dengan objek lain
    void OnCollisionEnter2D(Collision2D collision)
    {
        //untuk mendeteksi tabrakan dengan objek yang memiliki tag "Dinding"
        if (collision.gameObject.CompareTag("Dinding"))
        {
            //untuk membalik arah gerak objek saat bertabrakan dengan dinding
            Debug.Log("Bertabrakan dengan dinding");
            //untuk membalik arah gerak objek
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
    public void TambahSkor()
    {
        interaksi12B.Score.text = "Skor:" + interaksi12B.skor.ToString();
        //mengubah Score  di script Interaksi12 menjadi "Skor:" diikuti dengan nilai skor
    }
}
public enum ArahGerakB
    {
        Kiri,
        Kanan,
        Atas,
        Bawah
    }