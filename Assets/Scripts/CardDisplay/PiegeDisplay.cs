using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PiegeDisplay : MonoBehaviour
{
    [SerializeField] private PiegeSO _piege;

    [SerializeField] private TMP_Text _cardNameText;
    [SerializeField] private TMP_Text _effectText;
    [SerializeField] private Image _rarityImage;
    [SerializeField] private Image _rubyRarityImage;

    [SerializeField] private Image _artwork;

    [SerializeField] private TMP_Text _rubyText;

    [SerializeField] private Image _extensionLogo;

    void Start()
    {
        if(_piege == null) { return; }

        _cardNameText.text = _piege.CardName;
        _effectText.text = _piege.Effect;
        _rarityImage.sprite = _piege.Rarity;
        _rubyRarityImage.sprite = _piege.RubyRarity;

        _artwork.sprite = _piege.Artwork;

        _rubyText.text = _piege.RubyCost.ToString();

        _extensionLogo.sprite = _piege.Extension;
    }
}
