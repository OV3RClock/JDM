using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nouveau Passepasse", menuName = "Carte Passepasse")]
public class PassepasseSO : ScriptableObject
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
    [SerializeField] private int _manaCost;
    public int ManaCost { get => _manaCost; }

    [Tooltip("Points d'attaque")]
    [SerializeField] private int _att;
    public int Att { get => _att; }

    [Tooltip("Points de vie")]
    [SerializeField] private int _health;
    public int Health { get => _health; }

    [Header("Informations autres")]

    [Tooltip("Archetype de la carte")]
    [SerializeField] private string _archetype;
    public string Archetype { get => _archetype; }

    [Tooltip("Extension de la carte")]
    [SerializeField] private string _extension;
    public string Extension { get => _extension; }
}
