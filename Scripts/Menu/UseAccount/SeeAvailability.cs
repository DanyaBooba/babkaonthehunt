using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeAvailability : MonoBehaviour
{
    [SerializeField] private Toast toast;
    [SerializeField] private GameObject awaitLogin;

    private AccountConstants constants;
    private AccountMenusChange menu;

    private string url;

    private string email;
    private string password;

    private void Start()
    {
        constants = GetComponent<AccountConstants>();
        menu = GetComponent<AccountMenusChange>();
        menu.IsLogin();

        awaitLogin.SetActive(false);
        url = constants.ReturnURL();
    }

    public void SetData(string email, string password)
    {
        if(EmailCorrect(email) && password.Length > 0)
        {
            this.email = email;
            this.password = password;

            StartCoroutine(CheckAccount());
        }
        else
        {
            toast.Send("Data is null", "SeeAvailability");
        }
    }

    private IEnumerator CheckAccount()
    {
        Debug.Log("Check Account");
        awaitLogin.SetActive(true);

        WWWForm wwwForm = new WWWForm();
        wwwForm.AddField("email", email);
        wwwForm.AddField("password", password);

        WWW www = new WWW(url + "/db__login.php", wwwForm);
        yield return www;

        //Debug.Log("[WWW] " + www.text);

        awaitLogin.SetActive(false);
        if (www.error != null)
        {
            toast.Send(www.error, "SeeAvailability");
            yield break;
        }

        if (isError(www.text) == true)
        {
            toast.Send(www.text, "SeeAvailability");
            yield break;
        }

        PlayerPrefs.SetString("dataEmail", email);
        PlayerPrefs.SetString("dataPassword", password);

        menu.IsAccount();
        yield return false;
    }

    public void LogoffAccount()
    {
        PlayerPrefs.DeleteKey("dataEmail");
        PlayerPrefs.DeleteKey("dataPassword");

        menu.IsLogin();
    }

    private bool isError(string text)
    {
        return (text[0].ToString() == "4" && text[1].ToString() == "0" && text[2].ToString() == "4");
    }

    private bool EmailCorrect(string email)
    {
        return true;
    }
}
