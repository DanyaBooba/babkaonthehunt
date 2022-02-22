using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HillMoveUpDown : MonoBehaviour
{
    [SerializeField] private GameObject prefabDot;
    private GameObject[] pointsObj;

    private int number;
    private float waitTime;
    private float waitTimeValue = 0f;
    
    private float speed = .5f;
    private float upside = .4f;

    private Vector2 position;
    private bool dead;
    
    private void Start()
    {
        pointsObj = new GameObject[2];
        position = transform.position;

        pointsObj[0] = Instantiate(prefabDot, new Vector2(position.x, position.y + upside), Quaternion.identity);
        pointsObj[1] = Instantiate(prefabDot, new Vector2(position.x, position.y - upside), Quaternion.identity);

        int random = UnityEngine.Random.Range(0, pointsObj.Length);
        transform.position = pointsObj[random].transform.position;
        waitTime = waitTimeValue;
    }

    public void GetDestory()
    {
        dead = true;
        Destroy(pointsObj[0]);
        Destroy(pointsObj[1]);
    }

    private void FixedUpdate()
    {
        if (pointsObj.Length <= 0 || dead) return;
        
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
        float vector = Vector3.Distance(transform.position, pointsObj[number].transform.position);
        return vector;
    }

    private Vector3 VectorMoveTowards()
    {
        Vector3 vector = Vector3.MoveTowards(transform.position, pointsObj[number].transform.position, speed * Time.deltaTime);
        return vector;
    }

    private void NextNumber()
    {
        waitTime = waitTimeValue;

        number++;
        if (number >= pointsObj.Length)
            number = 0;
    }
}
