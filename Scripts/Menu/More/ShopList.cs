using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShopList : MonoBehaviour
{
    [Header("Обьекты")]
    [SerializeField] private Image babkaObj;
    [SerializeField] private Text nameObj;

    [SerializeField] private GameObject priceObj;
    [SerializeField] private Text priceText;

    [SerializeField] private GameObject buyObj;
    [SerializeField] private GameObject applyObj;
    [SerializeField] private GameObject activeObj;

    [SerializeField] private Text moneyObj;

    [Header("Значения")]
    [SerializeField] private Sprite[] imagesBabka;
    [SerializeField] private int[] prices;
    [SerializeField] private string[] names;

    private void Start()
    {
        priceText = priceObj.GetComponent<Text>();
    }

    public void UpdateUI(int id, bool isBuy, bool isActive)
    {
        ChangeID(id, isBuy, isActive);
    }

    public int ReturnPrice(int id)
    {
        return prices[id];
    }

    private void ChangeID(int id, bool isBuy, bool isActive)
    {
        nameObj.text = names[id];
        moneyObj.text = GetCoins() + "$";

        babkaObj.sprite = imagesBabka[id];
        priceObj.SetActive(true);
        priceText.text = prices[id] + "$";

        SetBuy(isBuy);
        SetActiveSkin(isActive);
    }

    private void SetBuy(bool active)
    {
        applyObj.SetActive(active);
        buyObj.SetActive(!active);
        priceObj.SetActive(!active);
    }

    private void SetActiveSkin(bool active)
    {
        activeObj.SetActive(active);
    }

    private int GetCoins()
    {
        return PlayerPrefs.GetInt("coins");
    }
}
