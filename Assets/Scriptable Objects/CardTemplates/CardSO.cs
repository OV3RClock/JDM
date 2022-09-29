using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardSO : ScriptableObject
{
    [Tooltip("Prefab")]
    [SerializeField] private GameObject _cardPrefab;
    public GameObject CardPrefab { get => _cardPrefab; }

    public abstract GameObject SpawnCard(Transform spawnPoint, float scale);
}
