using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private AudioMixer _mixer;

    private void Start()
    {
        if(PlayerPrefs.HasKey("volume")) { _slider.value = PlayerPrefs.GetFloat("volume"); }
    }

    public void SetVolume(float volume)
    {
        _mixer.SetFloat("volume", Mathf.Log10(volume) * 20);
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("volume", _slider.value);
        PlayerPrefs.Save();
    }
}
