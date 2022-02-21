using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FAQMore : MonoBehaviour
{
    [SerializeField] private GameObject[] smallButtons;
    [SerializeField] private GameObject[] more;

    private void Start()
    {
        ArrayBruteForce(more, -1);
    }

    public void Open(int index)
    {
        ReverseArrayBruteForce(smallButtons, index);
        ArrayBruteForce(more, index);
    }

    public void Close()
    {
        ReverseArrayBruteForce(smallButtons, -1);
        ArrayBruteForce(more, -1);
    }

    private void ArrayBruteForce(GameObject[] array, int exc)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i].SetActive(Compare(i, exc));
        }
    }

    private void ReverseArrayBruteForce(GameObject[] array, int exc)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i].SetActive(!Compare(i, exc));
        }
    }

    private bool Compare(int fir, int sec)
    {
        return fir == sec;
    }
}
