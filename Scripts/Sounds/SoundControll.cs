using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class SoundControll : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup mixer;
    private float min = -80f;
    private float max = 0f;

    //int
    private string ppSaveBackground = "play-music-background";
    private string ppSaveSounds = "play-music";

    private string mixerBackground = "BackgroundSound";
    private string mixerSounds = "Sounds";

    private void Start()
    {
        if(PlayerPrefs.HasKey(ppSaveBackground) == false)
            PlayerPrefs.SetInt(ppSaveBackground, 1);

        if(PlayerPrefs.HasKey(ppSaveSounds) == false)
            PlayerPrefs.SetInt(ppSaveSounds, 1);

        SetNewSettings();        
    }

    public void ChangeSound()
    {
        GetOutSound();
        SetNewSettings();
    }

    public void ChangeBackground()
    {
        GetOutBackground();
        SetNewSettings();
    }

    private void GetOutSound()
    {
        int now = PlayerPrefs.GetInt(ppSaveSounds);

        if (now == 0)
            now = 1;
        else
            now = 0;
        
        PlayerPrefs.SetInt(ppSaveSounds, now);
    }

    private void GetOutBackground()
    {
        int now = PlayerPrefs.GetInt(ppSaveBackground);

        if (now == 0)
            now = 1;
        else
            now = 0;
        
        PlayerPrefs.SetInt(ppSaveBackground, now);
    }

    private void SetNewSettings()
    {
        //Задает новые настройки звука в ход
        if (PlayerPrefs.GetInt(ppSaveBackground) == 1)
        {
            mixer.audioMixer.SetFloat(mixerBackground, max);
        }
        else
        {
            mixer.audioMixer.SetFloat(mixerBackground, min);
        }

        if (PlayerPrefs.GetInt(ppSaveSounds) == 1)
        {
            mixer.audioMixer.SetFloat(mixerSounds, max);
        }
        else
        {
            mixer.audioMixer.SetFloat(mixerSounds, min);
        }
    }
}
