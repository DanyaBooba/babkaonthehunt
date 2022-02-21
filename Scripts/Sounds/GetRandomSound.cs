using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRandomSound : MonoBehaviour
{
    [SerializeField] private AudioClip[] background;
    private AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
        PlayRandomBackgroundSound();
    }

    private void PlayRandomBackgroundSound()
    {
        int i = Random.Range(0, background.Length);
        audio.clip = background[i];
        audio.Play();
    }
}
