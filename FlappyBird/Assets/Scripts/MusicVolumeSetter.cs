using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolumeSetter : MonoBehaviour
{
    [SerializeField] 
    private AudioSource audioSource;
    [SerializeField]
    private AudioSource jumpSoundEffect;
    [SerializeField]
    private AudioSource deathSoundEffect;
    public Slider volumeSlider;
    public Slider sfxSlider;


    //private float musicVolume = 1f;
    float sfxVolume;
    float musicVolume;
    private void Start()
    {
        musicVolume = PlayerPrefs.GetFloat("MusicVolume", 1f);
        volumeSlider.value = musicVolume;
        SetVolume(musicVolume);

        sfxVolume = PlayerPrefs.GetFloat("SFXVolume", 1f);
        sfxSlider.value = sfxVolume;
        SetSFX(sfxVolume);
    }
    public void SaveVolume()
    {
        // Slider'ın değerini alın ve PlayerPrefs'e kaydedin
        float musicVolume = volumeSlider.value;
        PlayerPrefs.SetFloat("MusicVolume", musicVolume);
        PlayerPrefs.Save(); // Değişiklikleri kaydedin
    }
    public void SaveSFX()
    {
        float sfxVolume = volumeSlider.value;
        PlayerPrefs.SetFloat("SFXVolume", sfxVolume);
        PlayerPrefs.Save(); // Değişiklikleri kaydedin
    }
    public void SetSFX(float volume)
    {
        jumpSoundEffect.volume = volume;
        deathSoundEffect.volume = volume;
    }
    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }

    public void NoMusic()
    {
        musicVolume = 0;
    }
}
