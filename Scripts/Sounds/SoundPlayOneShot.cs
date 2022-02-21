using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayOneShot : MonoBehaviour
{
    [SerializeField] private AudioClip[] sounds;
    private AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void PublicPlayClick()
    {
        PlayOneShot(0);
    }

    public void PublicPlayStartGame()
    {
        PlayOneShot(1);
    }

    private void PlayOneShot(int i)
    {
        //PlayOneShot
        audio.PlayOneShot(sounds[i]);
    }
}
