using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nouveau Kop1", menuName = "Carte Kop1")]
public class Kop1SO : ScriptableObject
{
    [Header("Informations generales")]

    [Tooltip("Nom de la carte")]
    [SerializeField] private string _cardName;
    public string CardName { get => _cardName; }

    [Tooltip("Effet de la carte")]
    [SerializeField] private string _effect;
    public string Effect { get => _effect; }
    
    [Tooltip("Rarete de la carte")]
    [SerializeField] private string _rarity;
    public string Rarity { get => _rarity; }

    [Header("Illustration")]

    [Tooltip("Illustration de la carte")]
    [SerializeField] private Sprite _artwork;
    public Sprite Artwork { get => _artwork; }

    [Header("Statistiques")]

    [Tooltip("Cout en rubis")]
    [SerializeField] private int _rubyCost;
    public int RubyCost { get => _rubyCost; }

    [Tooltip("Street Cred")]
    [SerializeField] private int _stc;
    public int Stc { get => _stc; }

    [Tooltip("Defense")]
    [SerializeField] private int _def;
    public int Def { get => _def; }

    [Header("Informations autres")]

    [Tooltip("Archetype de la carte")]
    [SerializeField] private string _archetype;
    public string Archetype { get => _archetype; }

    [Tooltip("Extension de la carte")]
    [SerializeField] private Sprite _extension;
    public Sprite Extension { get => _extension; }
}
