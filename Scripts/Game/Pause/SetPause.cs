using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPause : MonoBehaviour
{
    private Pause pause;
    private Platform platform;

    private bool pauseNow;

    private void Start()
    {
        pause = GetComponent<Pause>();
        platform = GameObject.FindGameObjectWithTag("Player").GetComponent<Platform>();

        PauseOff();
    }

    private void Update()
    {
        if(platform.isAndroid() == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Pause();
            }
        }
    }

    public void PausePublic()
    {
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
