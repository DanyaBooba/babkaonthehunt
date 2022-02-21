using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageBabka : MonoBehaviour
{
    [SerializeField] private Sprite[] images;

    [SerializeField] private bool inOpenworld;
    [SerializeField] private bool inSpace;

    private SpriteRenderer babka;

    private float transperentDown = 1f;
    private float transperentUp;
    private float speed = 0.3f;

    private bool startDown;
    private bool startUp;

    private int skinNumber;

    private void Start()
    {
        babka = GetComponent<SpriteRenderer>();

        if(inOpenworld == false)
        {
            if (inSpace == true)
                ChangeSprite(images[3]);
        }
        else
        {
            Debug.Log(skinNumber);
            ChangeSprite(images[skinNumber]);
        }
    }

    public void StartTransperent()
    {
        startDown = true;
    }

    public void ChangeSpriteID(int id)
    {
        Debug.Log(id);
        babka.sprite = images[id];
    }

    public void SetUpTransperent(float transperent)
    {
        babka.color = ColorTransperent(transperent);
        transperentUp = transperent;
        startUp = true;
    }

    public void ChangeSkinNumber(int id)
    {
        skinNumber = id;
    }

    private void FixedUpdate()
    {
        if (startDown)
        {
            if(transperentDown > 0)
            {
                transperentDown -= speed * Time.deltaTime;
                babka.color = ColorTransperent(transperentDown);
            }
            else
            {
                startDown = false;
            }            
        }

        if (startUp)
        {
            if(transperentUp != 1)
            {
                transperentUp += speed * Time.deltaTime;
                babka.color = ColorTransperent(transperentUp);
            }
            else
            {
                babka.color = ColorTransperent(1f);
                startUp = false;
            }
        }
    }

    private Color ColorTransperent(float transperent)
    {
        Color color = Color.white;
        color.a = transperent;
        return color;
    }

    private void ChangeSprite(Sprite sprite)
    {
        babka.sprite = sprite;
    }
}
