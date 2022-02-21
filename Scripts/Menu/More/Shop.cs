using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    private ShopList list;
    private string saveName = "shop";
    
    private int length = 4;
    private int[] buys;

    private int id;
    private int coins;

    private int activeID;

    private void Start()
    {
        Debug.Log(PlayerPrefs.GetString(saveName));

        coins = PlayerPrefs.GetInt("coins");
        list = GetComponent<ShopList>();

        buys = LoadArray();

        UpdateUI();
    }

    private void OnEnable()
    {
        UpdateUI();
    }

    public void Next()
    {
        id = ChangeID(id, 1);
        UpdateUI();
    }

    public void Last()
    {
        id = ChangeID(id, -1);
        UpdateUI();
    }

    public void Buy()
    {
        int price = list.ReturnPrice(id);
        if (CanBuy(price))
        {
            buys = AddToArray(buys, id);
            Save(buys);

            coins = Subtract(PlayerPrefs.GetInt("coins"), price);
            PlayerPrefs.SetInt("coins", coins);
            UpdateUI();
        }
        else
        {
            Debug.Log("Can't buy");
        }
    }

    public void SetActiveSkin()
    {
        activeID = id;
        PlayerPrefs.SetInt("activeSkin", activeID);

        UpdateUI();
    }

    private int ChangeID(int now, int step)
    {
        now += step;
        if (now < 0)
        {
            now = length;
            now -= 1;
        }
        else if (now >= length)
        {
            now = 0;
        }

        return now;
    }

    //Вспомогательные методы
    private void UpdateUI()
    {
        if(list != null)
            list.UpdateUI(id, isBuy(buys, id), SkinActive(id));
    }

    private int[] LoadArray()
    {
        int[] array;
        if (PlayerPrefs.HasKey(saveName))
            array = ParseKey(PlayerPrefs.GetString(saveName));
        else
            array = new int[length];

        return array;
    }

    private void Save(int[] array)
    {
        string save = "";
        for(int i = 0; i < array.Length; i++)
        {
            save += array[i].ToString();
        }

        PlayerPrefs.SetString(saveName, save);
    }

    private int[] ParseKey(string toparse)
    {
        int[] array = new int[length];
        for(int i = 0; i < toparse.Length; i++)
        {
            if(toparse[i].ToString() == "1")
                array[i] = 1;
        }

        return array;
    }

    private void DebugArray(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log("[" + i + "] " + array[i]);
        }
    }

    private bool CanBuy(int price)
    {
        return coins >= price;
    }

    private bool isBuy(int[] array, int id)
    {
        return array[id] == 1;
    }

    private bool SkinActive(int id)
    {
        return activeID == id;
    }

    private int[] AddToArray(int[] array, int id)
    {
        for(int i = 0; i < array.Length; i++)
        {
            if (i == id)
            {
                array[i] = 1;
                break;
            }
        }

        return array;
    }
    
    private int Subtract(int from, int what)
    {
        return from - what;
    }
}
