using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    private string urlSite = "https://creagoo.ru";
    private string urlGooglePlay = "https://live.creagoo.ru/assets/php/content/url-conversion.php?w=googleplay";
    private string urlWeb = "https://live.creagoo.ru/games/babkaonthehuntclassic/online";
    private string urlItchio = "https://live.creagoo.ru/assets/php/content/url-conversion.php?w=itchio";
    
    public void OpenSite()
    {
        URL(urlSite);
    }

    public void OpenGooglePlay()
    {
        URL(urlGooglePlay);
    }

    public void GetOpenURL(string url)
    {
        URL(url);
    }

    public void OpenWeb()
    {
        URL(urlWeb);
    }

    public void OpenItchio()
    {
        URL(urlItchio);
    }

    private void URL(string url)
    {
        Application.OpenURL(url);
    }
}
