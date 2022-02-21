using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    private Platform platform;

    private float speedValue = 4;
    private float speed;
    private float moveInput;
    private bool input;

    private void Start()
    {
        platform = GameObject.FindGameObjectWithTag("Player").GetComponent<Platform>();
        speed = speedValue;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        var move = collision.gameObject.GetComponent<Move>();

        if (move != null)
        {
            moveInput = move.ReturnVerticalMove();
            if (Abs(moveInput) > 0f)
                input = true;
        }

        if (collision.gameObject.CompareTag("Player") && input)
        {
            if(moveInput != 0)
            {
                if (moveInput < -0.3f)
                    speed = -speedValue;
                else if(moveInput > 0.3f)
                    speed = speedValue;
            }

            move.GetMove(speed);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        var move = collision.gameObject.GetComponent<Move>();
        if(move != null)
        {
            move.EndMove();
            input = false;
        }
    }

    private float Abs(float value)
    {
        return Mathf.Abs(value);
    }
}
