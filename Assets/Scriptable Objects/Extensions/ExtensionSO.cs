using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName ="Extension", fileName = "Nouvelle Extension")]
public class ExtensionSO : ScriptableObject
{
    [Header("Informations generales")]
    
    [SerializeField] private string _extensionName;
    public string ExtensionName { get => _extensionName; }

    [SerializeField] private string _description;
    public string Description { get => _description; }

    [SerializeField] private int _packCost;
    public int PackCost { get => _packCost; }

    [Header("Artworks")]

    [SerializeField] private Sprite _extensionIcon;
    public Sprite ExtensionIcon { get => _extensionIcon; }

    [SerializeField] private Sprite _titleArtwork;
    public Sprite TitleArtwork { get => _titleArtwork; }
}
