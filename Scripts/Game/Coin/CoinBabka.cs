using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CoinBabka : MonoBehaviour
{
    public Text uiCoins;

    private int coins;

    private void Start()
    {
        
        coins = PlayerPrefs.GetInt("coins");
        UpdateUI();
    }

    public void PickCoins(int count)
    {
        ChangeCoins(count);
    }

    private void ChangeCoins(int count)
    {
        coins += count;
        PlayerPrefs.SetInt("coins", coins);
        UpdateUI();
    }

    private void UpdateUI()
    {
        uiCoins.text = coins + "$";
    }
}
