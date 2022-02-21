using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FinishAndPick : MonoBehaviour
{
    [SerializeField] private Text textMasc;
    [SerializeField] private string text;

    private void Start()
    {
        SetTag("Untagged");
        ChangeText("");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var obj = collision.gameObject.GetComponent<PickItem>();
            if (obj.ReturnPickItem())
            {
                SetTag("Finish");
            }
            else
            {
                ChangeText(text);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ChangeText("");
        }
    }

    private void SetTag(string tag)
    {
        transform.gameObject.tag = tag;
    }

    private void ChangeText(string text)
    {
        textMasc.text = text;
    }
}
