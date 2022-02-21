using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BabkaTextUI : MonoBehaviour
{
    [SerializeField] private Text textUI;

    public void UpdateText(string text)
    {
        ChangeText(text);
    }

    public void ClearText()
    {
        ChangeText("");
    }

    private void ChangeText(string text)
    {
        textUI.text = text;
    }
}
