using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nouveau Kop1", menuName = "Carte/Carte Kop1")]
public class Kop1SO : CardSO
{
    [Header("Attribut(s) specifique(s) au type de carte")]

    [Tooltip("Street Cred")]
    [SerializeField] private int _stc;
    public int Stc { get => _stc; }

    [Tooltip("Resistance")]
    [SerializeField] private int _res;
    public int Res { get => _res; }

    public override GameObject SpawnCard(Transform spawnPoint, float scale)
    {
        GameObject _tmpGameObj = Instantiate(this.CardPrefab, spawnPoint);
        _tmpGameObj.GetComponent<Kop1Display>().Data = this;
        _tmpGameObj.transform.localScale = new Vector3(scale, scale, scale);
        return _tmpGameObj;
    }
}
