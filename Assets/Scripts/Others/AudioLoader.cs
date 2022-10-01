using UnityEngine;
using UnityEngine.Audio;

public class AudioLoader : MonoBehaviour
{
    [SerializeField] private AudioSO _audioLoader;
    public AudioMixerGroup _audioMixer;

    public void Awake()
    {
        Init();
    }

    private void Init()
    {
        foreach (var sound in _audioLoader.sounds)
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;
            sound.source.volume = sound.volume;
            sound.source.loop = sound.loop;
            sound.source.outputAudioMixerGroup = _audioMixer;
        }
    }
}
