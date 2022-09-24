using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PassepasseDisplay : MonoBehaviour
{
    [SerializeField] private PassepasseSO _passepasse;

    [SerializeField] private TMP_Text _cardNameText;
    [SerializeField] private TMP_Text _effectText;
    [SerializeField] private Image _rarityImage;
    [SerializeField] private Image _rubyRarityImage;

    [SerializeField] private Image _artwork;

    [SerializeField] private TMP_Text _rubyText;

    [SerializeField] private TMP_Text _archetypeText;
    [SerializeField] private Image _extensionLogo;

    void Start()
    {
        if(_passepasse == null) { return; }

        _cardNameText.text = _passepasse.CardName;
        _effectText.text = _passepasse.Effect;
        _rarityImage.sprite = _passepasse.Rarity;
        _rubyRarityImage.sprite = _passepasse.RubyRarity;

        _artwork.sprite = _passepasse.Artwork;
        
        _rubyText.text = _passepasse.RubyCost.ToString();

        _archetypeText.text = _passepasse.Archetype;
        _extensionLogo.sprite = _passepasse.Extension;
    }
}
