using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardShopMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text _extensionText;

    [SerializeField] private CardPrefabsSO _prefabs;
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
            page._button.GetComponent<Image>().sprite = page._extension.ExtensionIcon;
        }

        //Charger le premier nom d'extension
        _extensionText.text = _pages[0]._extension.ExtensionName;

        //Charger les 3 cartes
        for (int i = 0; i < _pages[0]._cards.Length; i++)
        {
            switch (_pages[0]._cards[i])
            {
                case AccrocheSO:
                    _currentCards[i] = Instantiate(_prefabs.AccrochePrefab, _cardSpawnPoints[i]);
                    _currentCards[i].GetComponent<AccrocheDisplay>()._accroche = (AccrocheSO)_pages[0]._cards[i];
                    _currentCards[i].transform.localScale = new Vector3(_scale, _scale, _scale);
                    break;
                case ClashSO:
                    _currentCards[i] = Instantiate(_prefabs.ClashPrefab, _cardSpawnPoints[i]);
                    _currentCards[i].GetComponent<ClashDisplay>()._clash = (ClashSO)_pages[0]._cards[i];
                    _currentCards[i].transform.localScale = new Vector3(_scale, _scale, _scale);
                    break;
                case FinishHimSO:
                    _currentCards[i] = Instantiate(_prefabs.FinishHimPrefab, _cardSpawnPoints[i]);
                    _currentCards[i].GetComponent<FinishHimDisplay>()._finishHim = (FinishHimSO)_pages[0]._cards[i];
                    _currentCards[i].transform.localScale = new Vector3(_scale, _scale, _scale);
                    break;
                case Kop1SO:
                    _currentCards[i] = Instantiate(_prefabs.Kop1Prefab, _cardSpawnPoints[i]);
                    _currentCards[i].GetComponent<Kop1Display>()._kop1 = (Kop1SO)_pages[0]._cards[i];
                    _currentCards[i].transform.localScale = new Vector3(_scale, _scale, _scale);
                    break;
                case PassepasseSO:
                    _currentCards[i] = Instantiate(_prefabs.PassepassePrefab, _cardSpawnPoints[i]);
                    _currentCards[i].GetComponent<PassepasseDisplay>()._passepasse = (PassepasseSO)_pages[0]._cards[i];
                    _currentCards[i].transform.localScale = new Vector3(_scale, _scale, _scale);
                    break;
                case PersonnageSO:
                    _currentCards[i] = Instantiate(_prefabs.PersonnagePrefab, _cardSpawnPoints[i]);
                    _currentCards[i].GetComponent<PersonnageDisplay>()._personnage = (PersonnageSO)_pages[0]._cards[i];
                    _currentCards[i].transform.localScale = new Vector3(_scale, _scale, _scale);
                    break;
                case PiegeSO:
                    _currentCards[i] = Instantiate(_prefabs.PiegePrefab, _cardSpawnPoints[i]);
                    _currentCards[i].GetComponent<PiegeDisplay>()._piege = (PiegeSO)_pages[0]._cards[i];
                    _currentCards[i].transform.localScale = new Vector3(_scale, _scale, _scale);
                    break;
                default:
                    break;
            }
        }

    }

    private void Update()
    {
        if(!_refresh) { return; }

        //Mettre a jour le nom de l'extension
        _extensionText.text = _pages[_index]._extension.ExtensionName;

        //Mettre a jour les 3 cartes
        for (int i = 0; i < _pages[_index]._cards.Length; i++)
        {
            if(_currentCards.Length != 0) { Destroy(_currentCards[i]); }
            switch (_pages[_index]._cards[i])
            {
                case AccrocheSO:
                    _currentCards[i] = Instantiate(_prefabs.AccrochePrefab, _cardSpawnPoints[i]);
                    _currentCards[i].GetComponent<AccrocheDisplay>()._accroche = (AccrocheSO)_pages[_index]._cards[i];
                    _currentCards[i].transform.localScale = new Vector3(_scale, _scale, _scale);
                    break;
                case ClashSO:
                    _currentCards[i] = Instantiate(_prefabs.ClashPrefab, _cardSpawnPoints[i]);
                    _currentCards[i].GetComponent<ClashDisplay>()._clash = (ClashSO)_pages[_index]._cards[i];
                    _currentCards[i].transform.localScale = new Vector3(_scale, _scale, _scale);
                    break;
                case FinishHimSO:
                    _currentCards[i] = Instantiate(_prefabs.FinishHimPrefab, _cardSpawnPoints[i]);
                    _currentCards[i].GetComponent<FinishHimDisplay>()._finishHim = (FinishHimSO)_pages[_index]._cards[i];
                    _currentCards[i].transform.localScale = new Vector3(_scale, _scale, _scale);
                    break;
                case Kop1SO:
                    _currentCards[i] = Instantiate(_prefabs.Kop1Prefab, _cardSpawnPoints[i]);
                    _currentCards[i].GetComponent<Kop1Display>()._kop1 = (Kop1SO)_pages[_index]._cards[i];
                    _currentCards[i].transform.localScale = new Vector3(_scale, _scale, _scale);
                    break;
                case PassepasseSO:
                    _currentCards[i] = Instantiate(_prefabs.PassepassePrefab, _cardSpawnPoints[i]);
                    _currentCards[i].GetComponent<PassepasseDisplay>()._passepasse = (PassepasseSO)_pages[_index]._cards[i];
                    _currentCards[i].transform.localScale = new Vector3(_scale, _scale, _scale);
                    break;
                case PersonnageSO:
                    _currentCards[i] = Instantiate(_prefabs.PersonnagePrefab, _cardSpawnPoints[i]);
                    _currentCards[i].GetComponent<PersonnageDisplay>()._personnage = (PersonnageSO)_pages[_index]._cards[i];
                    _currentCards[i].transform.localScale = new Vector3(_scale, _scale, _scale);
                    break;
                case PiegeSO:
                    _currentCards[i] = Instantiate(_prefabs.PiegePrefab, _cardSpawnPoints[i]);
                    _currentCards[i].GetComponent<PiegeDisplay>()._piege = (PiegeSO)_pages[_index]._cards[i];
                    _currentCards[i].transform.localScale = new Vector3(_scale, _scale, _scale);
                    break;
                default:
                    break;
            }
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
    [SerializeField] public Button _button;
    [SerializeField] public ExtensionSO _extension;
    [SerializeField] public CardSO[] _cards;
}
