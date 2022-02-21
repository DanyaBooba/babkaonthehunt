using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTextUI : MonoBehaviour
{
    [SerializeField] private string text;

    public string ReturnText()
    {
        return text;
    }
}
