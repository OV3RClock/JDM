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

    [Tooltip("Description de la carte")]
    [SerializeField] private string _description;
    public string Description { get => _description; }

    [Header("Illustration")]

    [Tooltip("Illustration de la carte")]
    [SerializeField] private Sprite _artwork;
    public Sprite Artwork { get => _artwork; }

    [Header("Statistiques")]

    [Tooltip("Cout en mana")]
    [SerializeField] private int _rubyCost;
    public int RubyCost { get => _rubyCost; }

    [Header("Informations autres")]

    [Tooltip("Archetype de la carte")]
    [SerializeField] private string _archetype;
    public string Archetype { get => _archetype; }

    [Tooltip("Extension de la carte")]
    [SerializeField] private string _extension;
    public string Extension { get => _extension; }
}
