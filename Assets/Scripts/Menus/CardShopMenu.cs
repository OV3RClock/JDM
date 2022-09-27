using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardShopMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text _extensionText;

    [SerializeField] private float _scale;

    [SerializeField] private Transform[] _cardSpawnPoints;

    [SerializeField] public ShopPage[] _pages;

    private GameObject[] _currentCards = new GameObject[3];

    [HideInInspector] public int _index = 0;
    private bool _refresh = false;

    private void Start()
    {
        //Charger les logos sur les boutons
        foreach(ShopPage page in _pages)
        {
            page.Button.GetComponent<Image>().sprite = page.Extension.ExtensionIcon;
        }

        //Charger le premier nom d'extension
        _extensionText.text = _pages[0].Extension.ExtensionName;

        //Charger les 3 cartes
        for (int i = 0; i < _pages[0].Cards.Length; i++)
        {
            _currentCards[i] = Instantiate(_pages[0].Cards[i].CardPrefab, _cardSpawnPoints[i]);
            _currentCards[i].GetComponent<CardDisplay>().Data = _pages[0].Cards[i];
            _currentCards[i].transform.localScale = new Vector3(_scale, _scale, _scale);
        }
    }

    private void Update()
    {
        if(!_refresh) { return; }

        //Mettre a jour le nom de l'extension
        _extensionText.text = _pages[_index].Extension.ExtensionName;

        //Mettre a jour les 3 cartes
        for (int i = 0; i < _pages[_index].Cards.Length; i++)
        {
            if(_currentCards.Length != 0) { Destroy(_currentCards[i]); }

            _currentCards[i] = Instantiate(_pages[_index].Cards[i].CardPrefab, _cardSpawnPoints[i]);
            _currentCards[i].GetComponent<CardDisplay>().Data = _pages[_index].Cards[i];
            _currentCards[i].transform.localScale = new Vector3(_scale, _scale, _scale);
        }

        _refresh = false;
    }

    public void OnClick(int index)
    {
        _index = index;
        _refresh = true;
    }
}

[Serializable]
public struct ShopPage
{
    [SerializeField] public Button Button;
    [SerializeField] public ExtensionSO Extension;
    [SerializeField] public CardSO[] Cards;
}
