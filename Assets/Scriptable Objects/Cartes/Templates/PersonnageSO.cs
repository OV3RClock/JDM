using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nouveau Personnage", menuName = "Carte Personnage")]
public class PersonnageSO : ScriptableObject
{
    [Header("Informations generales")]

    [Tooltip("Nom de la carte")]
    [SerializeField] private string _cardName;
    public string CardName { get => _cardName; }

    [Tooltip("Description de la carte")]
    [SerializeField] private string _effect;
    public string Effect { get => _effect; }

    [Header("Illustration")]

    [Tooltip("Illustration de la carte")]
    [SerializeField] private Sprite _artwork;
    public Sprite Artwork { get => _artwork; }

    [Header("Statistiques")]

    [Tooltip("Cout en rubis")]
    [SerializeField] private int _rubyCost;
    public int RubyCost { get => _rubyCost; }

    [Tooltip("Cout du pouvoir en rubis")]
    [SerializeField] private int _spellRubyCost;
    public int SpellRubyCost { get => _spellRubyCost; }

    [Header("Informations autres")]

    [Tooltip("Extension de la carte")]
    [SerializeField] private string _extension;
    public string Extension { get => _extension; }
}
