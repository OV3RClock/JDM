using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nouvelle Accroche", menuName = "Carte/Carte Accroche")]
public class AccrocheSO : CardSO
{
    [Header("Informations generales")]

    [Tooltip("Nom de la carte")]
    [SerializeField] private string _cardName;
    public string CardName { get => _cardName; }

    [Tooltip("Effet de la carte")]
    [SerializeField] private string _effect;
    public string Effect { get => _effect; }

    [Tooltip("Gemme de rarete")]
    [SerializeField] private Sprite _rarity;
    public Sprite Rarity { get => _rarity; }

    [Tooltip("Rubis de rarete")]
    [SerializeField] private Sprite _rubyRarity;
    public Sprite RubyRarity { get => _rubyRarity; }

    [Header("Illustration")]

    [Tooltip("Illustration de la carte")]
    [SerializeField] private Sprite _artwork;
    public Sprite Artwork { get => _artwork; }

    [Header("Statistiques")]

    [Tooltip("Cout en rubis")]
    [SerializeField] private int _rubyCost;
    public int RubyCost { get => _rubyCost; }

    [Header("Informations autres")]

    [Tooltip("Extension de la carte")]
    [SerializeField] private Sprite _extension;
    public Sprite Extension { get => _extension; }

    public override GameObject SpawnCard(Transform spawnPoint, float scale)
    {
        GameObject _tmpGameObj = Instantiate(this.CardPrefab, spawnPoint);
        _tmpGameObj.GetComponent<AccrocheDisplay>().Data = this;
        _tmpGameObj.transform.localScale = new Vector3(scale, scale, scale);
        return _tmpGameObj;
    }
}
