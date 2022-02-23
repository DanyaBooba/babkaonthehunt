using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SetPause : MonoBehaviour
{
    private InputControll controll;
    
    private Pause pause;
    private Platform platform;

    private bool pauseNow;

    private void Start()
    {
        pause = GetComponent<Pause>();
        platform = GameObject.FindGameObjectWithTag("Player").GetComponent<Platform>();

        PauseOff();
    }

    private void Awake()
    {
        controll = new InputControll();

        controll.Controll.PauseEscape.performed += context => OpenMenuPC();
    }

    private void OnEnable()
    {
        controll.Enable();
    }

    private void OnDisable()
    {
        controll.Disable();
    }

    private void OpenMenuPC()
    {
        if(!platform.isAndroid())
            Pause();
    }

    public void PausePublic()
    {
        if(platform.isAndroid())
            Pause();
    }

    public void SetTimeTrue()
    {
        Time.timeScale = 1f;
    }

    private void Pause()
    {
        bool pause = pauseNow;
        pauseNow = !pauseNow;

        if (pause == false)
        {
            PauseOn();
        }
        else
        {
            PauseOff();
        }
    }

    private void PauseOn()
    {
        pause.PauseSet(pauseNow);
        Time.timeScale = 0f;
    }

    private void PauseOff()
    {
        pause.PauseSet(pauseNow);
        Time.timeScale = 1f;
    }
}
