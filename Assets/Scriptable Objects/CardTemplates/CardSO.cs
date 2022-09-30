using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardSO : ScriptableObject
{
    #region Prefab/Artwork/Sfx

    [Header("Prefab/Artwork/Sfx")]

    [Tooltip("Prefab")]
    [SerializeField] private GameObject _cardPrefab;
    public GameObject CardPrefab { get => _cardPrefab; }

    [Tooltip("Illustration de la carte")]
    [SerializeField] private Sprite _artwork;
    public Sprite Artwork { get => _artwork; }

    [Tooltip("Son emit lorsque cette carte est jouee")]
    [SerializeField] private string _sfx;
    public string Sfx { get => _sfx; }

    #endregion

    #region Nom/Cout/Effet/Rarete/Rubis

    [Header("Informations generales")]

    [Tooltip("Nom de la carte")]
    [SerializeField] private string _cardName;
    public string CardName { get => _cardName; }

    [Tooltip("Cout en rubis")]
    [SerializeField] private int _rubyCost;
    public int RubyCost { get => _rubyCost; }

    [Tooltip("Effet de la carte")]
    [SerializeField, TextArea(1, 30)] private string _effect;
    public string Effect { get => _effect; }

    [Tooltip("Gemme de rarete")]
    [SerializeField] private Sprite _rarityGem;
    public Sprite RarityGem { get => _rarityGem; }

    [Tooltip("Rarete du rubis")]
    [SerializeField] private Sprite _rubyRarity;
    public Sprite RubyRarity { get => _rubyRarity; }

    #endregion

    #region Archetype/Extension/Jeton

    [Header("Informations autres")]

    [Tooltip("Archetype de la carte")]
    [SerializeField] private Archetype _archetype;
    public Archetype Archetype { get => _archetype; }

    [Tooltip("Extension de la carte")]
    [SerializeField] private Sprite _extension;
    public Sprite Extension { get => _extension; }

    [Tooltip("Lore de la carte")]
    [SerializeField, TextArea(1, 30)] private string _lore;
    public string Lore { get => _lore; }

    [Tooltip("Jeton")]
    [SerializeField] private bool _jeton;
    public bool Jeton { get => _jeton; }

    #endregion

    public abstract GameObject SpawnCard(Transform spawnPoint, float scale);
}

public enum Archetype
{ 
    NONE,
    KAIRA,
    DRAGON,
    GENOCIDE,
    TAMERE
}
