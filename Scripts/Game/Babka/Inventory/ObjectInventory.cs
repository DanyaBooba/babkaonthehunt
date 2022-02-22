using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInventory : MonoBehaviour
{
    private int id;
    private Toast toast;
    
    private string name_title;
    private string name_desc;

    public void PublicSetString(string name, string desc)
    {
        SetName(name);
        SetDesc(desc);
    }

    public void PublicSetID(int id)
    {
        SetID(id);
    }
    
    private void SetName(string name)
    {
        name_title = name;
    }

    private void SetDesc(string desc)
    {
        name_desc = desc;
    }

    private void SetID(int id)
    {
        this.id = id;
    }
}
