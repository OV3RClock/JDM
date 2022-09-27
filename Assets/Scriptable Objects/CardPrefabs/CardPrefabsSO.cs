using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Others/CardPrefabsSO")]
public class CardPrefabsSO : ScriptableObject
{
    [SerializeField] private GameObject _accrochePrefab;
    public GameObject AccrochePrefab { get => _accrochePrefab; }

    [SerializeField] private GameObject _clashPrefab;
    public GameObject ClashPrefab { get => _clashPrefab; }

    [SerializeField] private GameObject _finishHimPrefab;
    public GameObject FinishHimPrefab { get => _finishHimPrefab; }

    [SerializeField] private GameObject _kop1Prefab;
    public GameObject Kop1Prefab { get => _kop1Prefab; }

    [SerializeField] private GameObject _passepassePrefab;
    public GameObject PassepassePrefab { get => _passepassePrefab; }

    [SerializeField] private GameObject _personnagePrefab;
    public GameObject PersonnagePrefab { get => _personnagePrefab; }

    [SerializeField] private GameObject _piegePrefab;
    public GameObject PiegePrefab { get => _piegePrefab; }

}
