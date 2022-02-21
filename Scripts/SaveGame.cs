using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    [SerializeField] private string name;

    public void SaveNameString(string value)
    {
        if(name != null)
            PlayerPrefs.SetString(name, value);
    }

    public void SaveNameInt(int value)
    {
        if (name != null)
            PlayerPrefs.SetInt(name, value);
    }

    public void SaveNameFloat(float value)
    {
        if (name != null)
            PlayerPrefs.SetFloat(name, value);
    }
}
