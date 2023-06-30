using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVolumeSetter : MonoBehaviour
{
    [SerializeField] 
    private AudioSource audioSource;
    [SerializeField]
    private AudioSource jumpSoundEffect;
    [SerializeField]
    private AudioSource deathSoundEffect;


    private float musicVolume = 1f;
    private float sfxVolume = 1f;

    void Update()
    {
        audioSource.volume = musicVolume;
        jumpSoundEffect.volume = sfxVolume;
        deathSoundEffect.volume = sfxVolume;
    }
    
    public void SetVolume(float volume)
    {
        musicVolume = volume;
    }
    public void SetSFX(float volume)
    {
        sfxVolume = volume;
    }
    public void NoMusic()
    {
        musicVolume = 0;
    }
}
