using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timmer : MonoBehaviour
{
    int waktu;
    public float MaksimumWaktu;
    public TMP_Text Textimer;
    public bool Waktuberjalan = true;
    public KeyCode StartCourotine;
    public KeyCode StopCourotine;
    public Coroutine HitungTimerCoroutine;
    public Image ProgressFill;

    private void Update()
    {
        if(Input.GetKeyDown(StartCourotine))
        {
            if(HitungTimerCoroutine == null)
            {
                HitungTimerCoroutine = StartCoroutine(HitungTimer());
            }
            
        }
        if(Input.GetKeyDown(StopCourotine))
        {
            if(HitungTimerCoroutine != null)
            {
                StopCoroutine(HitungTimerCoroutine);
                HitungTimerCoroutine = null; 
            }
        }
    }
    
    IEnumerator HitungTimer()
    {
        while(Waktuberjalan == true && waktu < MaksimumWaktu)
        {
            waktu = waktu + 1;
            Textimer.text = waktu.ToString();
            ProgressFill.fillAmount = waktu / MaksimumWaktu;
            yield return new WaitForSeconds(1);
        }
        
    }
        
}
