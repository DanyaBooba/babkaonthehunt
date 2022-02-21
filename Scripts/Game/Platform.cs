using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private int mobile__pc__editor = -1;

    private void Start()
    {
        mobile__pc__editor = PlatformSet();
        Debug.Log(WhatPlatform(mobile__pc__editor));
    }

    public int ReturnPlatform()
    {
        return mobile__pc__editor;
    }

    public string WhatPlatform(int index)
    {
        if (index == 1) return "[Mobile] " + index;
        if (index == 2) return "[PC] " + index;
        if (index == 3) return "[Editor] " + index;
        return "[404] " + index;
    }

    public void WhatPlatformNow()
    {
        Debug.Log(WhatPlatform(mobile__pc__editor));
    }

    public bool isAndroid()
    {
        return mobile__pc__editor == 1;
    }

    public bool isPC()
    {
        return mobile__pc__editor == 2;
    }

    public bool isEditor()
    {
        return mobile__pc__editor == 3;
    }


    private void Update()
    {
        //debug
        if (Input.GetKeyDown(KeyCode.P))
        {
            mobile__pc__editor = Next(mobile__pc__editor, 3);
            Debug.Log(WhatPlatform(mobile__pc__editor));
        }
    }

    private int PlatformSet()
    {
        if (Application.isMobilePlatform) return 1;
        else if (Application.isEditor) return 3;
        return 2;
    }

    private int Next(int index, int max)
    {
        if (index <= 0) return 1;
        if (index >= max) return 1;
        return index += 1;
    }
}
