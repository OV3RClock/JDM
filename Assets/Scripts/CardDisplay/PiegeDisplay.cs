using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PiegeDisplay : MonoBehaviour
{
    [SerializeField] private PiegeSO _piege;

    [SerializeField] private Image _artwork;

    [SerializeField] private TMP_Text _nametext;

    [SerializeField] private TMP_Text _rubyText;

    [SerializeField] private TMP_Text _effectText;


    //[SerializeField] private Image _extensionText; LOGO

    //[SerializeField] private Image _rarity; A VOIR SELON TEMPLATE

    void Start()
    {
        _nametext.text = _piege.CardName;

        _artwork.sprite = _piege.Artwork;
        
        _rubyText.text = _piege.RubyCost.ToString();

        _effectText.text = _piege.Effect;
    }
}
