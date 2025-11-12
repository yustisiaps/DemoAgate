using System;
using UnityEngine;
using UnityEngine.UI;

public class SlideShow : MonoBehaviour
{
    public DatabaseGambar databaseGambar;
    public Image objectImage;
    public int indexGambar = 0;
    public void Next()
    {
        if (indexGambar < databaseGambar.ListGambar.Count + 1)
        {
            indexGambar = indexGambar + 1;
        }
        else
        {
            indexGambar = indexGambar;
        }
        objectImage.sprite = databaseGambar.ListGambar[indexGambar];
    }
    public void Previous()
    {
        if (indexGambar <= 0)
        {
            indexGambar = databaseGambar.ListGambar.Count - 1;
        }
        else
        {
            indexGambar = indexGambar;
        }
        objectImage.sprite = databaseGambar.ListGambar[indexGambar];
    }
}
