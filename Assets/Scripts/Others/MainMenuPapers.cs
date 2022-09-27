using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuPapers : MonoBehaviour
{
    [SerializeField] private Image _artwork;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private MenuPapersSO _data;
    private bool refresh = false;

    void Start()
    {
        int rand = UnityEngine.Random.Range(0, _data.Kop1s.Length);
        _artwork.sprite = _data.Kop1s[rand].Artwork;

        rand = UnityEngine.Random.Range(0, _data.Descriptions.Length);
        _text.text = _data.Descriptions[rand];
    }

    void Update()
    {
        if(!refresh) { return; }

        int rand = UnityEngine.Random.Range(0, _data.Kop1s.Length);
        _artwork.sprite = _data.Kop1s[rand].Artwork;

        rand = UnityEngine.Random.Range(0, _data.Descriptions.Length);
        _text.text = _data.Descriptions[rand];

        refresh = false;
    }

    public void NextPaper()
    {
        refresh = true;
    }
}
