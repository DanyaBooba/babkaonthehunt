using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneFallDown : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    public GameObject stone;

    private void Start()
    {
        rb = stone.GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();

        sprite.color = Transperent(0.2f);
        rb.isKinematic = true;
    }

    public void Trigger()
    {
        sprite.color = Transperent(0f);
        rb.isKinematic = false;
    }

    private Color Transperent(float transperent)
    {
        Color color = Color.white;
        color.a = transperent;
        return color;
    }
}
