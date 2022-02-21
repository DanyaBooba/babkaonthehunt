using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioClip soundPick;
    [SerializeField] private GameObject effect;
    [SerializeField] private int count;

    private SpriteRenderer sprite;
    private CircleCollider2D collider;

    private AudioSource audio;
    
    private float transperent = 1f;
    private float speed = 1.2f;
    private bool pick;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        collider = GetComponent<CircleCollider2D>();
        audio = GetComponent<AudioSource>();

        collider.enabled = true;
        sprite.color = ColorTransperent(1f);
    }

    public int ReturnCount()
    {
        return count;
    }

    public void GetDestroy()
    {
        pick = true;
        collider.enabled = false;
        Effects();
    }

    private void Effects()
    {
        Instantiate(effect, transform.position, Quaternion.identity);
        audio.PlayOneShot(soundPick);
    }

    private void FixedUpdate()
    {
        if (pick)
        {
            if(transperent > 0)
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
        Color color = sprite.color;
        color.a = transperent;
        return color;
    }
}
