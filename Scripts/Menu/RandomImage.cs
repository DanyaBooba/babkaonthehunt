using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class RandomImage : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites;
    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
        int index = Random.Range(0, sprites.Length);
        image.sprite = sprites[index];
    }
}
