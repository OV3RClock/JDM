using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AccrocheDisplay : MonoBehaviour
{
    [SerializeField] private AccrocheSO _accroche;

    [SerializeField] private TMP_Text _cardNameText;
    [SerializeField] private TMP_Text _effectText;
    [SerializeField] private Image _rarityImage;
    [SerializeField] private Image _rubyRarityImage;

    [SerializeField] private Image _artwork;

    [SerializeField] private TMP_Text _rubyText;

    [SerializeField] private Image _extensionLogo;

    void Start()
    {
        if(_accroche == null) { return; }

        _cardNameText.text = _accroche.CardName;
        _effectText.text = _accroche.Effect;
        _rarityImage.sprite = _accroche.Rarity;
        _rubyRarityImage.sprite = _accroche.RubyRarity;

        _artwork.sprite = _accroche.Artwork;

        _rubyText.text = _accroche.RubyCost.ToString();

        _extensionLogo.sprite = _accroche.Extension;
    }
}
