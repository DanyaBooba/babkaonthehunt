using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsVoids : MonoBehaviour
{
    [SerializeField] private Toast toast;

    public void DeleteKey(string key)
    {
        PlayerPrefs.DeleteKey(key);
        toast.Send("Key " + key + " removed", "SettingsVoids");
    }

    public void DeleteAll()
    {
        PlayerPrefs.DeleteAll();
        toast.Send("All keys removed", "SettingsVoids");
    }
}
