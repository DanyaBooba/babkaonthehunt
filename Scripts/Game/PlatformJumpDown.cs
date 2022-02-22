using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformJumpDown : MonoBehaviour
{
    private PlatformEffector2D platform;
    private float time = .7f;
    
    private void Start()
    {
        platform = GetComponent<PlatformEffector2D>();
    }

    public void StartOffCollider()
    {
        StartCoroutine(GetOffCollider());
    }
    
    private IEnumerator GetOffCollider()
    {
        platform.surfaceArc = 0;
        yield return new WaitForSeconds(time);

        platform.surfaceArc = 180;
        yield return false;
    }
}
