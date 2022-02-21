using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SnapScrolling : MonoBehaviour
{
    [SerializeField] private GameObject pan;
    [SerializeField] private Sprite[] panImages;

    private int panCount;

    private float widthPan;
    private float space = 50f;
    private float timeMove = 6f;

    private GameObject[] listPans;
    private Vector2[] listTransformPans;

    private RectTransform contentTransform;
    private Vector2 contentVector;

    private bool nowScroll;
    private int selectPanID;

    private void Start()
    {
        panCount = panImages.Length;
        contentTransform = GetComponent<RectTransform>();

        var panTransform = pan.GetComponent<RectTransform>();
        widthPan = panTransform.sizeDelta.x;

        CreateItems(pan);
    }

    public void SetScroll(bool scroll)
    {
        nowScroll = scroll;
    }

    private void CreateItems(GameObject pan)
    {
        listPans = new GameObject[panCount];
        listTransformPans = new Vector2[panCount];

        for (int i = 0; i < panCount; i++)
        {
            listPans[i] = Instantiate(pan, transform, false);
            listPans[i].GetComponent<Image>().sprite = panImages[i];

            if (i > 0)
            {
                float x = listPans[i - 1].transform.localPosition.x;
                float y = listPans[i].transform.localPosition.y;
                listPans[i].transform.localPosition = PositionPan(x, y);
            }

            listTransformPans[i] = -listPans[i].transform.localPosition;
        }
    }

    private void Update()
    {
        float nearest = float.MaxValue;

        for (int i = 0; i < panCount; i++)
        {
            float distance = Mathf.Abs(contentTransform.anchoredPosition.x - listTransformPans[i].x);
            if (distance < nearest)
            {
                nearest = distance;
                selectPanID = i;
            }
        }

        Active(selectPanID);

        if (nowScroll == false)
        {
            var contentX = contentTransform.anchoredPosition.x;
            var panX = listTransformPans[selectPanID].x;
            contentVector.x = Mathf.SmoothStep(contentX, panX, timeMove * Time.fixedDeltaTime);
            contentVector.y = listTransformPans[selectPanID].y;

            contentTransform.anchoredPosition = contentVector;
        }
    }

    private void Active(int id)
    {
        for (int i = 0; i < panCount; i++)
        {
            Color color;

            if (i == id)
                color = ColorTransperent(1);
            else
                color = ColorTransperent(.5f);

            listPans[i].GetComponent<Image>().color = color;
        }
    }

    private Vector2 PositionPan(float x, float y)
    {
        Vector2 vector = new Vector2(x + widthPan + space, y);

        return vector;
    }

    private Color ColorTransperent(float transperent)
    {
        Color color = Color.white;
        color.a = transperent;
        return color;
    }
}
