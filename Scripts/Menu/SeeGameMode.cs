using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeGameMode : MonoBehaviour
{
    public GameObject[] gameBlocks;

    private string completeBasic;
    private string completeSpace;

    private void Start()
    {
        if (!PlayerPrefs.HasKey(completeBasic))
        {
            Disable(1);
            Disable(2);
        }

        if(PlayerPrefs.HasKey(completeBasic) && !PlayerPrefs.HasKey(completeSpace))
        {
            Disable(2);
        }
    }

    private void Disable(int id)
    {
        gameBlocks[id].SetActive(false);
    }

}
