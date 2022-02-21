using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hill : MonoBehaviour
{
    [SerializeField] private GameObject effect;
    [SerializeField] private float hill = 1f;

    private SpriteRenderer sprite;
    private CapsuleCollider2D collider;

    private float transperent = 1f;
    private float speed = 1.2f;
    private bool pick;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        collider = GetComponent<CapsuleCollider2D>();

        collider.enabled = true;
        sprite.color = ColorTransperent(1f);
    }

    public float ReturnHill()
    {
        return hill;
    }

    public void GetDestroy()
    {
        pick = true;
        collider.enabled = false;
        Effects();
    }

    private void Effects()
    {
        if (effect != null)
            Instantiate(effect, transform.position, Quaternion.identity);
    }

    private void FixedUpdate()
    {
        if (pick)
        {
            if (transperent > 0)
            {
                transperent -= speed * Time.deltaTime;
                sprite.color = ColorTransperent(transperent);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

    private Color ColorTransperent(float transperent)
    {
        Color color = Color.white;
        color.a = transperent;
        return color;
    }
}
