using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "Others/AudioSO")]
public class AudioSO : ScriptableObject
{
    public List<Sound> sounds;

    public List<string> _currentSounds = new();

    public void Play(string soundName)
    {
        Sound sound = sounds.Find(sound => sound.name == soundName);
        if (sound == null)
        {
            Debug.LogWarning("Son : " + soundName + " non trouvé !");
        }
        else
        {
            _currentSounds.Add(sound.name);
            sound.source.Play();
        }
    }

    public void PlaySFX(string soundName)
    {
        Sound sound = sounds.Find(sound => sound.name == soundName);
        if (sound == null)
        {
            Debug.LogWarning("SFX : " + soundName + " non trouvé !");
        }
        else
        {
            sound.source.Play();
        }
    }

    public void Stop(string soundName)
    {
        Sound sound = sounds.Find(sound => sound.name == soundName);
        if (sound == null)
        {
            Debug.LogWarning("Son : " + soundName + " non trouvé !");
        }
        else if (!_currentSounds.Contains(sound.name))
        {
            Debug.LogWarning("Son " + soundName + " n'est pas en cours de lecture !");
        }
        else
        {
            _currentSounds.Remove(sound.name);
            sound.source.Stop();
        }
    }

    public void StopAll()
    {
        if (_currentSounds.Count == 0) { return; }

        for(int i = 0; i < _currentSounds.Count; i++)
        {
            Sound sound = sounds.Find(sound => sound.name == _currentSounds[i]);
            sound.source.Stop();
        }
        _currentSounds.Clear();
    }

    public void StopAllExcept(string[] songsToPlay)
    {
        if (_currentSounds.Count == 0) { return; }

        //On isole les musiques a arreter
        List<string> songsToStop = new();
        for (int i = 0; i < _currentSounds.Count; i++)
        {
            if (!songsToPlay.Contains(_currentSounds[i]))
            {
                songsToStop.Add(_currentSounds[i]);
            }
        }

        //On arrete les musiques
        for (int i = 0; i < songsToStop.Count; i++)
        {
            Sound sound = sounds.Find(sound => sound.name == songsToStop[i]);
            sound.source.Stop();
            _currentSounds.Remove(songsToStop[i]);
        }
    }

    public bool IsPlaying(string soundName)
    {
        if (_currentSounds.Count == 0) { return false; }

        return _currentSounds.Contains(soundName);
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