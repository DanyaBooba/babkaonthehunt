using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField] private Transform parent;
    [SerializeField] private GameObject listItem;
    private int count;
    
    private ObjectInventory[] list;
    private int[] objSet;

    private GameObject[] listObjItem;

    private void SetItems()
    {
        objSet = new int[count];
        list = new ObjectInventory[count];
    }

    private void SetNull()
    {
        for (int i = 0; i < count; i++)
        {
            objSet[i] = 0;
            list[i] = null;
        }
    }

    private void SpawnObj()
    {
        listObjItem = new GameObject[count];
        
        for (int i = 0; i < count; i++)
        {
            listObjItem[i] = Instantiate(listItem, parent);
        }
    }

    private void SetNullID(int id)
    {
        objSet[id] = 0;
        list[id] = null;
    }

    private void ChangeStatusID(int idChange)
    {
        objSet[idChange] = 1;
    }

    private void GetItemSet(int id, ObjectInventory obj)
    {
        list[id] = obj;
    }
}
