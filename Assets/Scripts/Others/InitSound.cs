using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitSound : MonoBehaviour
{
    [SerializeField] private AudioSO _audio;
    [SerializeField] private string[] _soundsToPlay;

    void Start()
    {
        _audio.StopAllExcept(_soundsToPlay);

        for(int i = 0; i < _soundsToPlay.Length; i++)
        {
            if (!_audio.IsPlaying(_soundsToPlay[i])) { _audio.Play(_soundsToPlay[i]); }
        }
    }
}
