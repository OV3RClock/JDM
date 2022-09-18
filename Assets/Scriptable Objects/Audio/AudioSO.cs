using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AudioSO")]
public class AudioSO : ScriptableObject
{
    public List<Sound> sounds;
    [HideInInspector]
    public Sound _currentSound;

    public void Play(string soundName)
    {
        Sound sound = sounds.Find(sound => sound.name == soundName);
        if (sound == null)
        {
            Debug.LogWarning("Son " + soundName + " non trouvé !");
        }
        else
        {
            sound.source.Play();
            _currentSound = sound;
        }
    }

    public void Stop(string soundName)
    {
        Sound sound = sounds.Find(sound => sound.name == soundName);
        if (sound == null)
        {
            Debug.LogWarning("Son " + soundName + " non trouvé !");
        }
        else if (sound != _currentSound)
        {
            Debug.LogWarning("Son " + soundName + " n'est pas en cours de lecture !");
        }
        else
        {
            sound.source.Stop();
            _currentSound = null;
        }
    }

    public Sound IsPlaying()
    {
        return _currentSound;
    }
}

[Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;
    [Range(0f, 1f)]
    public float volume;
    public bool loop;
    [HideInInspector]
    public AudioSource source;
}