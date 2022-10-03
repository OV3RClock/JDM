using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nouveau Personnage", menuName = "Carte/Carte Personnage")]
public class PersonnageSO : CardSO
{
    [Header("Attribut(s) specifique(s) au type de carte")]

    [Tooltip("Cout du pouvoir en rubis")]
    [SerializeField] private int _spellRubyCost;
    public int SpellRubyCost { get => _spellRubyCost; }

    public override GameObject SpawnCard(Transform spawnPoint, float scale)
    {
        GameObject _tmpGameObj = Instantiate(this.CardPrefab, spawnPoint);
        _tmpGameObj.GetComponent<PersonnageDisplay>().Data = this;
        _tmpGameObj.transform.localScale = new Vector3(scale, scale, scale);
        return _tmpGameObj;
    }
}
