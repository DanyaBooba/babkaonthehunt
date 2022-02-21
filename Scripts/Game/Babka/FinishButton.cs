using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishButton : MonoBehaviour
{
    [SerializeField] private GameObject buttonFinish;
    [SerializeField] private GameObject buttonEnd;

    private void Start()
    {
        FinishDisable();
        EndDisable();
    }

    public void EndAnable()
    {
        SetActiveButton(buttonEnd, true);
    }

    public void EndDisable()
    {
        SetActiveButton(buttonEnd, false);
    }

    public void FinishAnable()
    {
        SetActiveButton(buttonFinish, true);
    }

    public void FinishDisable()
    {
        SetActiveButton(buttonFinish, false);
    }

    private void SetActiveButton(GameObject obj, bool active)
    {
        obj.SetActive(active);
    }
}
