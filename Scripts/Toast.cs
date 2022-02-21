using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toast : MonoBehaviour
{
    private AndroidJavaObject currentActivity;
    private bool isMobile;

    private void Awake()
    {
        isMobile = Application.isMobilePlatform;
    }

    private void Start()
    {
        if (isMobile)
        {
            AndroidJavaClass UnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            currentActivity = UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        }

    }

    public void Send(string mess, string nameScript)
    {
        if (isMobile)
        {
            var toast = AwakeToast(mess);
            toast.Call("show");
        }
        else
        {
            Debug.Log("[Toast] '" + mess + "' [From: " + nameScript + "]");
        }
    }

    public void PublicSendMailButton(string text)
    {
        if (isMobile)
        {
            var toast = AwakeToast(text);
            toast.Call("show");
        }
        else
        {
            Debug.Log("[Toast] '" + text + "'");
        }
    }

    private AndroidJavaObject AwakeToast(string mess)
    {
        AndroidJavaObject context = currentActivity.Call<AndroidJavaObject>("getApplicationContext");
        AndroidJavaClass Toast = new AndroidJavaClass("android.widget.Toast");
        AndroidJavaObject javaString = new AndroidJavaObject("java.lang.String", mess);
        AndroidJavaObject toast = Toast.CallStatic<AndroidJavaObject>("makeText", context, javaString, Toast.GetStatic<int>("LENGTH_SHORT"));

        return toast;
    }
}
