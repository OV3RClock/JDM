using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nouveau FinishHim", menuName = "Carte FinishHim")]
public class FinishHimSO : ScriptableObject
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

    [Header("Informations autres")]

    [Tooltip("Extension de la carte")]
    [SerializeField] private Sprite _extension;
    public Sprite Extension { get => _extension; }
}
