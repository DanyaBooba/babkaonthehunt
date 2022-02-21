using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    [SerializeField] private bool useRestraints;
    
    private Transform player;
    private Health health;

    public float distanceLeft, distanceRight;
    public float distanceUp, distanceBottom;

    private float additiveX = 0.5f;
    private float additiveY = 0.75f;

    private float higherFromY = 1.1f;
    private float higherFromX;
    
    private float dumping = 2.85f;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        health = player.GetComponent<Health>();
    }

    private void FixedUpdate()
    {
        if (health.isDead() == true)
            return;

        Vector3 target;
        target = new Vector3(player.position.x + higherFromX, player.position.y + higherFromY, transform.position.z);

        Vector3 currentPosition = Vector3.Lerp(transform.position, target, dumping * Time.deltaTime);
        transform.position = currentPosition;

        float x_ = transform.position.x;
        float y_ = transform.position.y;
        if (useRestraints)
        {
            x_ = Mathf.Clamp(transform.position.x, distanceLeft, distanceRight);
            y_ = Mathf.Clamp(transform.position.y, distanceBottom, distanceUp);
        }

        transform.position = new Vector3(x_, y_, transform.position.z);
    }

    private void OnDrawGizmos()
    {
        if (useRestraints == false)
            return;
        
        Gizmos.color = Color.green;

        float left = distanceLeft - additiveX;
        float right = distanceRight + additiveX;
        float up = distanceUp + additiveY;
        float bottom = distanceBottom - additiveY;

        Gizmos.DrawLine(new Vector2(left, up), new Vector2(right, up));
        Gizmos.DrawLine(new Vector2(left, bottom), new Vector2(right, bottom));
        Gizmos.DrawLine(new Vector2(left, up), new Vector2(left, bottom));
        Gizmos.DrawLine(new Vector2(right, up), new Vector2(right, bottom));
    }
}
