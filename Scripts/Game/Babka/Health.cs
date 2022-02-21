using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Health : MonoBehaviour
{
    private ImageBabka image;

    public Image[] hearts;
    public Sprite heart_full;
    public Sprite heart_empty;
    public Sprite heart_none;

    private float healthMax;
    private static float health = 6f;
    private float healthValue = 6f;

    private float stopDamage = .5f;
    private bool damage;

    private bool dead;

    private void Start()
    {
        image = GetComponent<ImageBabka>();

        if (health == 0)
            health = healthValue;

        healthMax = healthValue;
        CheckHealth();
    }

    public void GetDamage(float value)
    {
        StartCoroutine(ChangeHealth(-value));
    }

    public void UpHealth(float value)
    {
        StartCoroutine(ChangeHealth(value));
    }

    public void GetDeath()
    {
        StartCoroutine(ChangeHealth(-healthMax));
    }

    private IEnumerator ChangeHealth(float value)
    {
        if(value < 0 && damage == false)
        {
            damage = true;
            image.SetUpTransperent(0.6f);

            health += value;
            CheckHealth();

            yield return new WaitForSeconds(stopDamage);
            damage = false;
        }
        else if(value > 0)
        {
            health += value;
            CheckHealth();
        }
    }

    private void CheckHealth()
    {
        if (health <= 0f)
        {
            dead = true;
            health = 0f;
        }
        else
        {
            if(health > healthMax)
                health = healthMax;

            Debug.Log("[Health] " + health);
        }

        HeartUI(health);
    }

    private void HeartUI(float health)
    {
        if (health > 0)
        {
            if (health > 4)
            {
                SetSpriteHearts(heart_full);

                if (isMultiple(health, 2) == false)
                    hearts[0].sprite = heart_empty;
            }
            else if (health > 2 && health <= 4)
            {
                SetSpriteHearts(heart_full);
                hearts[0].sprite = heart_none;

                if (isMultiple(health, 2) == false)
                    hearts[1].sprite = heart_empty;
            }
            else
            {
                SetSpriteHearts(heart_full);
                hearts[0].sprite = heart_none;
                hearts[1].sprite = heart_none;

                if (isMultiple(health, 2) == false)
                    hearts[2].sprite = heart_empty;
            }
        }
        else
        {
            SetSpriteHearts(heart_none);
        }
    }

    private void SetSpriteHearts(Sprite sprite)
    {
        for(int i = 0; i < hearts.Length; i++)
        {
            hearts[i].sprite = sprite;
        }
    }

    private bool isMultiple(float what, int to)
    {
        return what % to == 0;
    }

    public bool isDead()
    {
        return dead;
    }
}
