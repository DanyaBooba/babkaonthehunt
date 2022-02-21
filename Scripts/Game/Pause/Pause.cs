using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pause;

    public void PauseSet(bool pauseNow)
    {
        PauseEdit(pauseNow);
    }

    private void PauseEdit(bool pauseNow)
    {
        pause.SetActive(pauseNow);
    }
}
