using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModalView : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject modal_panel;

    private void Start()
    {
        ArrayBruteForce(objects, -1);
        modal_panel.SetActive(false);
    }

    public void _See(int id)
    {
        ArrayBruteForce(objects, id);
        SetTime(0f);
    }

    public void _NotSee()
    {
        SetTime(1f);
        ArrayBruteForce(objects, -1);
    }

    private void ArrayBruteForce(GameObject[] array, int exc)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i].SetActive(Compare(i, exc));
        }

        modal_panel.SetActive(Bool(exc));
    }

    private bool Compare(int fir, int sec)
    {
        return fir == sec;
    }

    private void SetTime(float delta)
    {
        Time.timeScale = delta;
    }

    private bool Bool(int i)
    {
        return i > -1;
    }
}
