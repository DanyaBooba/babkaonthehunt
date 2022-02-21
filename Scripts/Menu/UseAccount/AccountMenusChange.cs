using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccountMenusChange : MonoBehaviour
{
    public GameObject loginMenu;
    public GameObject accountMenu;

    public void IsLogin()
    {
        SeeLogin(true);
    }

    public void IsAccount()
    {
        SeeLogin(false);
    }

    private void SeeLogin(bool active)
    {
        loginMenu.SetActive(active);
        accountMenu.SetActive(!active);
    }
}
