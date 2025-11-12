using UnityEngine;

public class Interaksi12B : MonoBehaviour
{
    public SquareMove12 squareMove12;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GerakKiri()
    {
        squareMove12.arahGerakB = ArahGerakB.Kiri;
    }
    public void GerakKanan()
    {
        squareMove12.arahGerakB = ArahGerakB.Kanan;
    }
    public void GerakAtas()
    {
        squareMove12.arahGerakB = ArahGerakB.Atas;
    }
    public void GerakBawah()
    {
        squareMove12.arahGerakB = ArahGerakB.Bawah;
    }
}
