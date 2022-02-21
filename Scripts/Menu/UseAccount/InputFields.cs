using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InputFields : MonoBehaviour
{
    private SeeAvailability availability;

    public InputField inputEmail;
    public InputField inputPassword;

    private void Start()
    {
        availability = GetComponent<SeeAvailability>();

        string email = PlayerPrefs.GetString("dataEmail");
        string password = PlayerPrefs.GetString("dataPassword");

        if(email.Length > 0 && password.Length > 0)
            availability.SetData(email, password);
    }

    public void Submit()
    {
        string email = inputEmail.text;
        string password = inputPassword.text;

        availability.SetData(email, password);
    }
}
