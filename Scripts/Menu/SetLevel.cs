using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SetLevel : MonoBehaviour
{
    [SerializeField] private GameObject menuload;
    private LoadLevel load;

    private float timeawait;
    
    private string ppBasicComplete;
    private string ppSpaceComplete;
    //private string ppSpaceComplete;

    private void Start()
    {
        menuload.SetActive(false);
        load = GetComponent<LoadLevel>();
        timeawait = Random.Range(1f, 1.75f);
    }

    public void StartBasic()
    {
        StartCoroutine(LoadLevel(load.LoadBasic));
    }

    public void StartSpace()
    {
        StartCoroutine(LoadLevel(load.LoadSpace));
    }

    public void StartChernobyl()
    {
        StartCoroutine(LoadLevel(load.LoadChernobyl));
    }

    public void StartOpenWorld()
    {
        
        StartCoroutine(LoadLevel(load.LoadOpenWorld));
    }

    private IEnumerator LoadLevel(Action callback)
    {
        menuload.SetActive(true);

        new WaitForSeconds(timeawait);
        callback.Invoke();
        
        yield return false;
    }
}
