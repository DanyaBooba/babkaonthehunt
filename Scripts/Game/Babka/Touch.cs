using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    private Health health;
    private Attack attack;
    private CoinBabka coinBabka;
    private FinishButton finish;
    private FinishButton endGame;
    private BabkaTextUI textUI;

    private PlatformJumpDown platformDown;
    
    private void Start()
    {
        health = GetComponent<Health>();
        attack = GetComponent<Attack>();
        coinBabka = GetComponent<CoinBabka>();
        finish = GetComponent<FinishButton>();
        textUI = GetComponent<BabkaTextUI>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("[Tag Collision] " + collision.gameObject.tag);

        if (collision.gameObject.CompareTag("Enemy"))
        {
            var enemy = collision.gameObject.GetComponent<Enemy>();
            if(enemy != null)
            {
                float enemyDamage = enemy.ReturnDamage();
                health.GetDamage(enemyDamage);
                enemy.Damage(attack.ReturnDamage());
            }
        }

        if (collision.gameObject.GetComponent<PlatformJumpDown>())
        {
            if(platformDown == null)
                platformDown = collision.gameObject.GetComponent<PlatformJumpDown>();
        }
        else
        {
            platformDown = null;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("[Tag Trigger] " + collision.gameObject.tag);

        if (collision.gameObject.CompareTag("Hill"))
        {
            var hill = collision.gameObject.GetComponent<Hill>();
            if (hill != null)
            {
                float hillValue = hill.ReturnHill();
                health.UpHealth(hillValue);
                hill.GetDestroy();
            }
        }

        if (collision.gameObject.CompareTag("Coin"))
        {
            var coin = collision.gameObject.GetComponent<Coin>();
            if (coin != null)
            {
                coinBabka.PickCoins(coin.ReturnCount());
                coin.GetDestroy();
            }
        }

        if (collision.gameObject.CompareTag("StoneZone"))
        {
            var zone = collision.gameObject.GetComponent<StoneFallDown>();
            if (zone != null)
            {
                zone.Trigger();
            }
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            finish.FinishAnable();
        }

        if (collision.gameObject.CompareTag("FinishEnd"))
        {
            finish.EndAnable();
        }

        var touchTextUI = collision.gameObject.GetComponent<ShowTextUI>();
        if (touchTextUI != null)
        {
            string text = touchTextUI.ReturnText();
            textUI.UpdateText(text);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            finish.FinishDisable();
        }

        if (collision.gameObject.CompareTag("FinishEnd"))
        {
            finish.EndDisable();
        }

        var touchTextUI = collision.gameObject.GetComponent<ShowTextUI>();
        if (touchTextUI != null)
        {
            textUI.ClearText();
        }
    }
    
    //Help methods
    //

    public void GetPlatformDown()
    {
        if(platformDown != null)
            platformDown.StartOffCollider();
    }
}
