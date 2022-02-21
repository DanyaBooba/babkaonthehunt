using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSkinBabka : MonoBehaviour
{
    private int numberSkin;
    private bool change;

    private void Start()
    {
        if(PlayerPrefs.HasKey("activeSkin"))
            numberSkin = PlayerPrefs.GetInt("activeSkin");

        change = numberSkin > 0;

        if (change == true)
            GetComponent<ImageBabka>().ChangeSkinNumber(numberSkin);
    }
}
