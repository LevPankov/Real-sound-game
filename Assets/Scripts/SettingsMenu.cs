using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Slider slider;

    private void Start()
    {
        float volume;
        audioMixer.GetFloat("Volume", out volume);
        slider.value = volume;
    }

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void SetFullScreen(bool isFoolScreen)
    {
        Screen.fullScreen = isFoolScreen;
    } 
}
