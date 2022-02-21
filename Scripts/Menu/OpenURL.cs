using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    private string urlSite = "https://creagoo.ru";
    private string urlGooglePlay = "https://live.creagoo.ru/assets/php/content/url-conversion.php?w=googleplay";

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

    private void URL(string url)
    {
        Application.OpenURL(url);
    }
}
