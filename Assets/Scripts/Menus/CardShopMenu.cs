using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardShopMenu : MonoBehaviour
{
    [SerializeField] public ExtensionSO[] Extensions;
    [SerializeField] private Button[] _buttons;

    [SerializeField] private TMP_Text _extensionText;
    [SerializeField] private TMP_Text _descriptionText;

    [SerializeField] private float _scale;

    [SerializeField] private Transform[] _cardSpawnPoints;

    [HideInInspector] public int _index = 0;
    private GameObject[] _currentCards = new GameObject[3];
    private bool _refresh = false;

    private void Start()
    {
        //Charger les logos sur les boutons
        for(int i = 0; i < _buttons.Length; i++)
        {
            _buttons[i].GetComponent<Image>().sprite = Extensions[i].ExtensionIcon;
        }

        _refresh = true;
    }

    private void Update()
    {
        if(!_refresh) { return; }

        //Mettre a jour le nom et la description de l'extension
        _extensionText.text = Extensions[_index].ExtensionName;
        _descriptionText.text = Extensions[_index].Description;

        //Mettre a jour les 3 cartes
        for (int i = 0; i < Extensions[_index].IconCardList.Length; i++)
        {
            if (_currentCards[i] != null) { Destroy(_currentCards[i]); }

            _currentCards[i] = Extensions[_index].IconCardList[i].SpawnCard(_cardSpawnPoints[i], _scale);
        }

        _refresh = false;
    }

    public void OnClick(int index)
    {
        _index = index;
        _refresh = true;
    }
}
