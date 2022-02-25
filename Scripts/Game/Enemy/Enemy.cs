using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private GameObject spriteHealth;
    [SerializeField] private Transform parentHealth;
    [SerializeField] private float health = 1f;

    [Header("Another")]
    [SerializeField] private GameObject effect;
    [SerializeField] private float damage = 1f;

    private bool dead;
    private float transperent = 1f;
    private float speedDead = 1.2f;

    private SpriteRenderer sprite;
    private CapsuleCollider2D collider;

    private GameObject[] listHealth;
    
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        collider = GetComponent<CapsuleCollider2D>();
        HealthUIInit();
    }

    public void Damage(float value)
    {
        ChangeHealth(-value);
    }

    public float ReturnDamage()
    {
        return damage;
    }

    private void ChangeHealth(float value)
    {
        health += value;
        HealthUIUpdate((int) health);
            
        if(health <= 0f)
            Dead();
    }

    private void Dead()
    {
        dead = true;
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
        if (dead)
        {
            if (transperent > 0)
            {
                transperent -= speedDead * Time.deltaTime;
                sprite.color = ColorTransperent(transperent);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

    private void HealthUIInit()
    {
        listHealth = new GameObject[(int) health];

        for (int i = 0; i < (int) health; i++)
        {
            listHealth[i] = Instantiate(spriteHealth, parentHealth);
        }
    }

    private void HealthUIUpdate(int hp)
    {
        for (int i = 0; i < listHealth.Length; i++)
        {
            if (i >= hp)
            {
                Destroy(listHealth[i]);
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
