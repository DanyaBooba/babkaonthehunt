using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    private string basicName = "basicLevel";
    private string spaceName = "spaceLevel";
    private string cherName = "cherLevel";

    public void LoadDefault()
    {
        GetLoadID(0);
    }

    public void LoadBasic()
    {
        string name = "basic__1";
        if (PlayerPrefs.GetString(basicName).Length > 0 && PlayerPrefs.HasKey(basicName))
            name = PlayerPrefs.GetString(basicName);

        GetLoadName(name);
    }

    public void LoadSpace()
    {
        string name = "space__1";
        if (PlayerPrefs.GetString(spaceName).Length > 0 && PlayerPrefs.HasKey(spaceName))
            name = PlayerPrefs.GetString(spaceName);

        GetLoadName(name);
    }

    public void LoadChernobyl()
    {
        string name = "chernobyl__1";
        if (PlayerPrefs.GetString(cherName).Length > 0 && PlayerPrefs.HasKey(cherName))
            name = PlayerPrefs.GetString(cherName);

        GetLoadName(name);
    }

    public void LoadOpenWorld()
    {
        string name = "openworld";
        GetLoadName(name);
    }

    public void ReloadLevel()
    {
        LoadLevelID(ActiveScene());
    }

    public void LoadLevelID(int number)
    {
        GetLoadID(number);
    }

    public void LoadNext()
    {
        int scene = ActiveScene();
        scene += 1;

        LoadLevelID(scene);
    }

    private void GetLoadID(int scene)
    {
        Debug.Log("load " + scene);
        SceneManager.LoadScene(scene);
    }

    private void GetLoadName(string scene)
    {
        Debug.Log("load " + scene);
        SceneManager.LoadScene(scene);
    }

    private int ActiveScene()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        return index;
    }
}
