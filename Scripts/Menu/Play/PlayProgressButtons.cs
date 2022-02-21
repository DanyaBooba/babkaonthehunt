using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayProgressButtons : MonoBehaviour
{
    [SerializeField] private GameObject[] cherG;
    [SerializeField] private GameObject[] swampG;
    [SerializeField] private GameObject[] spaceG;


    private string basicFinish = "basicEnd";
    private string cherFinish = "cherEnd";
    private string swampFinish = "swampEnd";
    private string spaceFinish = "spaceEnd";

    private int basic;
    private int cher;
    private int swamp;
    private int space;

    private void OnEnable()
    {
        Check();
    }

    private void Check()
    {
        basic = PlayerPrefs.GetInt(basicFinish);
        cher = PlayerPrefs.GetInt(cherFinish);
        swamp = PlayerPrefs.GetInt(swampFinish);
        space = PlayerPrefs.GetInt(spaceFinish);

        cherG[0].SetActive(FromInt(basic));
        cherG[1].SetActive(!FromInt(basic));

        swampG[0].SetActive(FromInt(cher));
        swampG[1].SetActive(!FromInt(cher));

        spaceG[0].SetActive(FromInt(swamp));
        spaceG[1].SetActive(!FromInt(swamp));
    }

    private bool FromInt(int i)
    {
        if (i == 0)
            return false;

        return true;
    }
}
