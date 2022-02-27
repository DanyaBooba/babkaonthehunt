using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class ModalView : MonoBehaviour
{
    [Header("Objs")]
    [SerializeField] private GameObject[] objects;
    [SerializeField] private GameObject modal_panel;
    [SerializeField] private ModalView moreModal;

    [Header("To Active Objects")]
    [SerializeField] private GameObject active;
    [SerializeField] private GameObject activeMore;
    [SerializeField] private GameObject activePlay;
    
    private InputControll controll;

    private void Start()
    {
        ArrayBruteForce(objects, -1);
        modal_panel.SetActive(false);
    }

    private void Awake()
    {
        controll = new InputControll();

        controll.Menu.GoBack.performed += context => _NotSee();
        controll.Menu.GetClick.performed += context => Click();
    }

    private void OnEnable()
    {
        controll.Enable();
    }

    private void OnDisable()
    {
        controll.Disable();
    }
    
    //Main methods
    //

    public void DisableMenu()
    {
        _NotSee();
        ActiveButton(active);
    }

    public void EnableSettings()
    {
        _See(0);
        ActiveButton(activeMore);
    }

    public void EnablePlay()
    {
        _See(1);
        ActiveButton(activePlay);
    }

    public void EnableMore()
    {
        _See(0);
        ActiveButton(activeMore);
    }
    
    //Help methods
    //
    
    private void _See(int id)
    {
        ArrayBruteForce(objects, id);
    }

    private void _NotSee()
    {
        ArrayBruteForce(objects, -1);
    }
    
    private void ActiveButton(GameObject obj)
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(obj);
    }

    public void Click()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
    }
    
    private void ArrayBruteForce(GameObject[] array, int exc)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i].SetActive(Compare(i, exc));
        }

        modal_panel.SetActive(Bool(exc));
    }

    private bool Compare(int fir, int sec)
    {
        return fir == sec;
    }

    private void SetTime(float delta)
    {
        Time.timeScale = delta;
    }

    private bool Bool(int i)
    {
        return i > -1;
    }
}
