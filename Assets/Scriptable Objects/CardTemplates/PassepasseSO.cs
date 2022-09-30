using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nouveau Passepasse", menuName = "Carte/Carte Passepasse")]
public class PassepasseSO : CardSO
{
    public override GameObject SpawnCard(Transform spawnPoint, float scale)
    {
        GameObject _tmpGameObj = Instantiate(this.CardPrefab, spawnPoint);
        _tmpGameObj.GetComponent<PassepasseDisplay>().Data = this;
        _tmpGameObj.transform.localScale = new Vector3(scale, scale, scale);
        return _tmpGameObj;
    }
}
