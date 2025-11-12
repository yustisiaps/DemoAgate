using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteraksiUI : MonoBehaviour
{
    public GameObject SquareMove12;
    public GameObject SquareUbahWarna;
    public TMP_Text KataBerubah;
    public TMP_Text NamaBerubah;
    public List<string> DaftarNama;
    public int idNama = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UbahKataKiri()
    {
        string kata = "Kiri";
        KataBerubah.text = kata;
    }
    public void UbahKataKanan()
    {
        string kata = "Kanan";
        KataBerubah.text = kata;
    }
    public void LanjutNama()
    {
        if (idNama < DaftarNama.Count - 1)
        {
            idNama++;
        }
        else
        {
            idNama = 0;
        }
        NamaBerubah.text = DaftarNama[idNama];
    }
    public void KembaliNama()
    {
        if (idNama <= 0)
        {
            idNama = DaftarNama.Count - 1;
        }
        else
        {
            idNama--;
        }
        NamaBerubah.text = DaftarNama[idNama];
    }
    public void UbahWarna(Color warna)
    {
        SpriteRenderer sr = SquareUbahWarna.GetComponent<SpriteRenderer>();
        sr.color = warna;
    }
    public void warnaMerah()
    {
        UbahWarna(Color.red);
    }
    public void warnaBiru()
    {
        UbahWarna(Color.blue);
    }
    public void warnaHijau()
    {
        UbahWarna(Color.green);
    }
    public void randomwarna()
    {
        Color warnaRandom = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        UbahWarna(warnaRandom);
    }
    public void Mulai()
    {
        SpriteMove sm = SquareMove12.GetComponent<SpriteMove>();
        sm.isMoving = true;
    }
    public void Berhenti()
    {
        SpriteMove sm = SquareMove12.GetComponent<SpriteMove>();
        sm.isMoving = false;
    }
    public void GerakKanan()
    {
        SpriteMove sm = SquareMove12.GetComponent<SpriteMove>();
        sm.moveRight = true;
    }
    public void GerakKiri()
    {
        SpriteMove sm = SquareMove12.GetComponent<SpriteMove>();
        sm.moveRight = false;
    }
}
