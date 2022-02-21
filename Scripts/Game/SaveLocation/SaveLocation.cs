using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SaveLocation : MonoBehaviour
{
    [SerializeField] private WhatLocation location;
    [SerializeField] private enum WhatLocation { None, Basic, Space, Chernobyl };

    private string basicName = "basicLevel";
    private string spaceName = "spaceLevel";
    private string chernobylName = "cherLevel";

    private void Start()
    {
        var scene = SceneManager.GetActiveScene().name;
        Debug.Log("scene: " + scene);

        if (location == WhatLocation.Basic)
            SaveBasic(scene);

        if (location == WhatLocation.Space)
            SaveSpace(scene);

        if (location == WhatLocation.Chernobyl)
            SaveChernobyl(scene);
    }

    private void SaveBasic(string nameLocation)
    {
        PlayerPrefs.SetString(basicName, nameLocation);
    }

    private void SaveSpace(string nameLocation)
    {
        PlayerPrefs.SetString(spaceName, nameLocation);
    }

    private void SaveChernobyl(string nameLocation)
    {
        PlayerPrefs.SetString(chernobylName, nameLocation);
    }
}
