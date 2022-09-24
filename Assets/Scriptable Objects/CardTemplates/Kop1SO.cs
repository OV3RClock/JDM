using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nouveau Kop1", menuName = "Carte/Carte Kop1")]
public class Kop1SO : ScriptableObject
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

    [Header("Effet sonore")]

    [Tooltip("Son emit lorsque jouee")]
    [SerializeField] private string _sfx;
    public string Sfx { get => _sfx; }

    [Header("Statistiques")]

    [Tooltip("Cout en rubis")]
    [SerializeField] private int _rubyCost;
    public int RubyCost { get => _rubyCost; }

    [Tooltip("Street Cred")]
    [SerializeField] private int _stc;
    public int Stc { get => _stc; }

    [Tooltip("Resistance")]
    [SerializeField] private int _res;
    public int Res { get => _res; }

    [Header("Informations autres")]

    [Tooltip("Archetype de la carte")]
    [SerializeField] private string _archetype;
    public string Archetype { get => _archetype; }

    [Tooltip("Extension de la carte")]
    [SerializeField] private Sprite _extension;
    public Sprite Extension { get => _extension; }

    [Tooltip("Jeton")]
    [SerializeField] private bool _jeton;
    public bool Jeton { get => _jeton; }
}
