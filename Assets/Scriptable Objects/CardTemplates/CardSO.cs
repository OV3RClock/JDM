using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSO : ScriptableObject
{
    [Tooltip("Prefab")]
    [SerializeField] private GameObject _cardPrefab;
    public GameObject CardPrefab { get => _cardPrefab; }
}
