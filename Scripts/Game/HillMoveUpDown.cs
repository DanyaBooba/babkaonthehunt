using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HillMoveUpDown : MonoBehaviour
{
    [SerializeField] private GameObject prefabDot;
    private Transform[] points;

    private int number;
    private float waitTime;
    private float waitTimeValue = 0f;
    
    private float speed = .5f;
    private float upside = .4f;

    private Vector2 position;
    
    private void Start()
    {
        points = new Transform[2];
        position = transform.position;

        points[0] = Instantiate(prefabDot, new Vector2(position.x, position.y + upside), Quaternion.identity).GetComponent<Transform>();
        points[1] = Instantiate(prefabDot, new Vector2(position.x, position.y - upside), Quaternion.identity).GetComponent<Transform>();

        int random = UnityEngine.Random.Range(0, points.Length);
        transform.position = points[random].position;
        waitTime = waitTimeValue;
    }

    private void FixedUpdate()
    {
        if (points.Length <= 0) return;
        
        transform.position = VectorMoveTowards();

        if (VectorDistance() < .1f)
        {
            if (waitTime <= 0)
                NextNumber();
            else
                waitTime -= Time.deltaTime;
        }
    }

    private float VectorDistance()
    {
        float vector = Vector3.Distance(transform.position, points[number].position);
        return vector;
    }

    private Vector3 VectorMoveTowards()
    {
        Vector3 vector = Vector3.MoveTowards(transform.position, points[number].position, speed * Time.deltaTime);
        return vector;
    }

    private void NextNumber()
    {
        waitTime = waitTimeValue;

        number++;
        if (number >= points.Length)
            number = 0;
    }
}
