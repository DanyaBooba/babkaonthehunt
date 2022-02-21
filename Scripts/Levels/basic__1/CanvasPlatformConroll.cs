using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasPlatformConroll : MonoBehaviour
{
    private bool ismobile;
    [SerializeField] private GameObject pc;
    [SerializeField] private GameObject mobile;

    private void Start()
    {
        ismobile = Application.isMobilePlatform;
        ForPC(!ismobile);
    }

    private void ForPC(bool active)
    {
        pc.SetActive(active);
        mobile.SetActive(!active);
    }
}
