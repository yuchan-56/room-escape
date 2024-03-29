using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    public AudioSource audioSource;
    public AudioSource SFXSource;
    public List<AudioClip> clipList;
    public Dictionary<string, AudioClip> soundClip = new Dictionary<string, AudioClip>();

    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        soundClip.Add("Menu", clipList[0]);
        soundClip.Add("InGame", clipList[1]);
        soundClip.Add("ClearEnd", clipList[2]);
        soundClip.Add("GameOver", clipList[3]);

        soundClip.Add("Button", clipList[4]);
        soundClip.Add("KeyOpen", clipList[5]);
        soundClip.Add("KeyFail", clipList[6]);
        soundClip.Add("Paper", clipList[7]);
        soundClip.Add("FireOn", clipList[8]);
        soundClip.Add("FireOff", clipList[9]);
        soundClip.Add("KeyDrop", clipList[10]);

        AudioPlay("Menu");
    }
    public void AudioPlay(string audioName)
    {
        audioSource.clip = soundClip[audioName];
        audioSource.Play();
    }

    public void SFXPlay(string SFXName)
    {
        SFXSource.PlayOneShot(soundClip[SFXName]);
    }

    public void ChangeVolume(float value)
    {
        audioSource.volume = value * 0.5f;
        SFXSource.volume = value;
    }
}
