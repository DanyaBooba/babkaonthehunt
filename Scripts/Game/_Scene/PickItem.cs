using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    public GameObject item;
    private bool pick;

    private void Start()
    {
        SetActiveItem(false);
    }

    public bool ReturnPickItem()
    {
        return pick;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pickObject"))
        {
            SetActiveItem(true);
            Destroy(collision.gameObject);
        }
    }

    private void SetActiveItem(bool active)
    {
        item.SetActive(active);
        pick = active;
    }
}
