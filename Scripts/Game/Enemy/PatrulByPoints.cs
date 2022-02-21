using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrulByPoints : MonoBehaviour
{
    public Transform[] points;
    private float speed = 5f;

    private int number;
    private float waitTime;
    private float waitTimeValue = 2.5f;

    private void Start()
    {
        waitTime = waitTimeValue;
    }

    private void FixedUpdate()
    {
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
