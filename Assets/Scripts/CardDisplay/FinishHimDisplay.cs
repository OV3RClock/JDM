using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FinishHimDisplay : MonoBehaviour
{
    [SerializeField] private FinishHimSO _finishHim;

    [SerializeField] private TMP_Text _cardNameText;
    [SerializeField] private TMP_Text _effectText;
    [SerializeField] private Image _rarityImage;
    [SerializeField] private Image _rubyRarityImage;

    [SerializeField] private Image _artwork;

    [SerializeField] private TMP_Text _rubyText;

    [SerializeField] private Image _extensionLogo;

    void Start()
    {
        if(_finishHim == null) { return; }

        _cardNameText.text = _finishHim.CardName;
        _effectText.text = _finishHim.Effect;
        _rarityImage.sprite = _finishHim.Rarity;
        _rubyRarityImage.sprite = _finishHim.RubyRarity;

        _artwork.sprite = _finishHim.Artwork;
        
        _rubyText.text = _finishHim.RubyCost.ToString();

        _extensionLogo.sprite = _finishHim.Extension;
    }
}
