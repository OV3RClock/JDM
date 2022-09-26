using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuPapers : MonoBehaviour
{
    [SerializeField] private AudioSO _audio;
    [SerializeField] private Image _artwork;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Kop1SO[] _kop1s;
    [SerializeField] private string[] _descriptions;
    private int index = 0;
    private bool refresh = false;

    void Start()
    {
        _audio.Play("city");

        _artwork.sprite = _kop1s[index].Artwork;

        int rand = UnityEngine.Random.Range(0, _descriptions.Length);
        _text.text = _descriptions[rand];
    }

    void Update()
    {
        if(!refresh) { return; }

        _artwork.sprite = _kop1s[index].Artwork;

        int rand = UnityEngine.Random.Range(0, _descriptions.Length);
        _text.text = _descriptions[rand];

        refresh = false;
    }

    public void NextPaper()
    {
        index++;
        if(index >= _kop1s.Length) { index = 0; refresh = true; }
    }
}
