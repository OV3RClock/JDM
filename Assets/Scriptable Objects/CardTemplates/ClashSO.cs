using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nouveau Clash", menuName = "Carte/Carte Clash")]
public class ClashSO : CardSO
{
    [Header("Attribut(s) spécifique(s) au type de carte")]

    [Tooltip("Punchline du clash")]
    [SerializeField, TextArea(1, 40)] private string _clashText;
    public string ClashText { get => _clashText; }

    public override GameObject SpawnCard(Transform spawnPoint, float scale)
    {
        GameObject _tmpGameObj = Instantiate(this.CardPrefab, spawnPoint);
        _tmpGameObj.GetComponent<ClashDisplay>().Data = this;
        _tmpGameObj.transform.localScale = new Vector3(scale, scale, scale);
        return _tmpGameObj;
    }
}
