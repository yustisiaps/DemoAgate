using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AksiTombol : MonoBehaviour
{
    public Sprite asetgambar;
    public Image image;
    public TMP_Text objectText;
    public void Aksi()
    {
        // image.sprite = asetgambar;
        // objectText.text = "Wellcome";
        // Debug.Log("Tombol Ditekan");
        SceneManager.LoadScene("SampleScene");
    }
}
