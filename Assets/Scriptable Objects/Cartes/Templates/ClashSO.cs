using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nouveau Clash", menuName = "Carte Clash")]
public class ClashSO : ScriptableObject
{
    [Header("Informations generales")]

    [Tooltip("Texte de la carte")]
    [SerializeField] private string _clashText;
    public string ClashText { get => _clashText; }

    [Tooltip("Effet de la carte")]
    [SerializeField] private string _effect;
    public string Effect { get => _effect; }

    [Tooltip("Rarete de la carte")]
    [SerializeField] private string _rarity;
    public string Rarity { get => _rarity; }

    [Header("Statistiques")]

    [Tooltip("Cout en rubis")]
    [SerializeField] private int _rubyCost;
    public int RubyCost { get => _rubyCost; }

    [Header("Informations autres")]

    [Tooltip("Archetype de la carte")]
    [SerializeField] private string _archetype;
    public string Archetype { get => _archetype; }

    [Tooltip("Extension de la carte")]
    [SerializeField] private Sprite _extension;
    public Sprite Extension { get => _extension; }
}
