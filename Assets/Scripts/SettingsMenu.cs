using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Slider slider;

    public Toggle toggle;

    private void Start()
    {
        float volume;
        audioMixer.GetFloat("Volume", out volume);
        slider.value = volume;
        if (!Screen.fullScreen) toggle.isOn = false;
        else toggle.isOn = true;
    }

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void SetFullScreen(bool isFoolScreen)
    {
        //Screen.fullScreen = isFoolScreen;
        if (!isFoolScreen)
        {
            Screen.SetResolution(640, 480, false);
        }
        else
        {
            Screen.SetResolution(1920, 1080, true);
        }
    } 
}
