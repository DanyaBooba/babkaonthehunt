using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrulPlatform : MonoBehaviour
{
    public Transform groundDecectLeft;
    public Transform groundDecectRight;

    private RaycastHit2D groundInfoLeft;
    private RaycastHit2D groundInfoRight;

    private float speed = 4.5f;
    private bool moveRight = true;
    private bool canChangeVector = true;

    private void FixedUpdate()
    {
        TwoDots();

        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void TwoDots()
    {
        groundInfoLeft = Raycast(groundDecectLeft);
        groundInfoRight = Raycast(groundDecectRight);

        if (canChangeVector)
        {
            if (groundInfoLeft.collider == false || groundInfoRight.collider == false)
            {
                StartCoroutine(ChangeRotationMove());
            }
        }
    }

    private IEnumerator ChangeRotationMove()
    {
        canChangeVector = false;

        float vector = 0;
        if (moveRight)
            vector = -180f;

        transform.eulerAngles = VectorToEulerAngles(vector);
        moveRight = !moveRight;

        yield return new WaitForSeconds(.5f);
        canChangeVector = true;
    }

    private Vector3 VectorToEulerAngles(float value)
    {
        Vector3 vector = new Vector3(0, value, 0);
        return vector;
    }

    private RaycastHit2D Raycast(Transform transform)
    {
        RaycastHit2D physics = Physics2D.Raycast(transform.position, Vector2.down, 2f);
        return physics;
    }
}
