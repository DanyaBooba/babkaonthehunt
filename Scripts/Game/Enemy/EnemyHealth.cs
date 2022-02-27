using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private GameObject spriteHealth;
    [SerializeField] private Transform parentHealth;
    
    private GameObject[] listHealth;
    
    public void HealthUIInit(int health)
    {
        listHealth = new GameObject[health];

        for (int i = 0; i < (int) health; i++)
        {
            listHealth[i] = Instantiate(spriteHealth, parentHealth);
        }
    }

    public void HealthUIUpdate(int hp)
    {
        for (int i = 0; i < listHealth.Length; i++)
        {
            if (i >= hp)
            {
                Destroy(listHealth[i]);
            }
        }
    }
}
