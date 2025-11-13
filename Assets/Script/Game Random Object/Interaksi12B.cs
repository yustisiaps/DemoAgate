using TMPro;
using UnityEngine;

public class Interaksi12B : MonoBehaviour
{
    //dekalarasi variabel
    public SquareMove12 squareMove12;
    public int skor;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //pendeteksi input dari tombol arah
    //dipakai untuk menggerakkan objek

    // Fungsi ini akan dipanggil ketika tombol "Kiri" ditekan.
    // Tugasnya adalah mengubah arah gerak objek menjadi ke kiri.

    public void GerakKiri()
    {
        // Mengatur arah gerak pada script SquareMove12 menjadi Kiri.
        squareMove12.arah = ArahGerakB.Kiri;
    }
    // Fungsi ini dipanggil ketika tombol "Kanan" ditekan.
    // Mengubah arah gerak objek ke arah kanan.
    public void GerakKanan()
    {
        // Mengatur arah gerak objek ke Kanan.
        squareMove12.arahGerakB = ArahGerakB.Kanan;
    }
    // Fungsi ini dipanggil ketika tombol "Atas" ditekan.
    // Mengubah arah gerak objek ke atas.
    public void GerakAtas()
    {
        // Mengatur arah gerak objek ke Atas.
        squareMove12.arahGerakB = ArahGerakB.Atas;
    }
    // Fungsi ini dipanggil ketika tombol "Bawah" ditekan.
    // Mengubah arah gerak objek ke bawah.
    public void GerakBawah()
    {
        // Mengatur arah gerak objek ke Bawah.
        squareMove12.arahGerakB = ArahGerakB.Bawah;
    }
}
