using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformaFall : MonoBehaviour
{
    [SerializeField] private float timeWall;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        IsKinematic(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(GetFall());
            StartCoroutine(GetDeath());
        }
    }

    private IEnumerator GetFall()
    {
        yield return new WaitForSeconds(timeWall);
        IsKinematic(false);

        yield return false;
    }

    private IEnumerator GetDeath()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);

        yield return false;
    }

    private void IsKinematic(bool active)
    {
        rb.isKinematic = active;
    }
}
