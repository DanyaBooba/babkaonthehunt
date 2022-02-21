using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePoints : MonoBehaviour
{
    //[SerializeField] private Transform[] points;
    private float speed = 5f;

    private int number;
    private float waitTime;
    private float waitTimeValue = 2.5f;

    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        //Debug.Log(player.transform.position);
    }
}
