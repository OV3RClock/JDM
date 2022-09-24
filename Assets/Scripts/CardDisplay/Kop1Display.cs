using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Kop1Display : MonoBehaviour
{
    [SerializeField] private Kop1SO _kop1;

    [SerializeField] private TMP_Text _cardNameText;
    [SerializeField] private TMP_Text _effectText;
    [SerializeField] private Image _rarityImage;
    [SerializeField] private Image _rubyRarityImage;

    [SerializeField] private Image _artwork;

    [SerializeField] private TMP_Text _rubyText;
    [SerializeField] private TMP_Text _stcText;
    [SerializeField] private TMP_Text _resText;
    
    [SerializeField] private TMP_Text _archetypeText;
    [SerializeField] private Image _extensionLogo;

    void Start()
    {
        if(_kop1 == null) { return; }

        _cardNameText.text = _kop1.CardName;
        _effectText.text = _kop1.Effect;
        _rarityImage.sprite = _kop1.Rarity;
        _rubyRarityImage.sprite = _kop1.RubyRarity;

        _artwork.sprite = _kop1.Artwork;

        _rubyText.text = _kop1.RubyCost.ToString();
        _stcText.text = _kop1.Stc.ToString();
        _resText.text = _kop1.Res.ToString();

        _archetypeText.text = _kop1.Archetype;
        _extensionLogo.sprite = _kop1.Extension;
    }
}
