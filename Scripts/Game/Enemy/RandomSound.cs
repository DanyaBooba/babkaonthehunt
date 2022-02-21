using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSound : MonoBehaviour
{
    [SerializeField] private AudioClip[] randomSounds;
    private AudioSource audioSource;

    private float timePauseValue = 1f;
    private float timePause;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if(timePause > 0f)
        {
            timePause -= timePauseValue * Time.deltaTime;
        }
        else
        {
            Debug.Log("check");
            StartCoroutine(Sound());
            timePause = timePauseValue;
        }

        /*
        if(audioSource.isPlaying == false && play == true)
            PlayRandomSound();
        */
    }

    private IEnumerator Sound()
    {
        if(audioSource.isPlaying == false)
        {
            int random = Random.Range(0, 40);
            if (random > 20 && random < 23)
                PlayRandomSound();
        }

        yield return false;
    }

    private void PlayRandomSound()
    {
        int random = Random.Range(0, randomSounds.Length);
        audioSource.PlayOneShot(randomSounds[random]);
    }
}
