using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PersonnageDisplay : MonoBehaviour
{
    [SerializeField] public PersonnageSO _personnage;

    [SerializeField] private TMP_Text _cardNameText;
    [SerializeField] private TMP_Text _effectText;
    [SerializeField] private Image _rarityImage;
    [SerializeField] private Image _rubyRarityImage;

    [SerializeField] private Image _artwork;

    [SerializeField] private TMP_Text _rubyText;
    //[SerializeField] private TMP_Text _spellRubyCostText;

    [SerializeField] private Image _extensionLogo;

    void Start()
    {
        if(_personnage == null) { return; }

        _cardNameText.text = _personnage.CardName;
        _effectText.text = _personnage.Effect;
        _rarityImage.sprite = _personnage.Rarity;
        _rubyRarityImage.sprite = _personnage.RubyRarity;

        _artwork.sprite = _personnage.Artwork;

        _rubyText.text = _personnage.RubyCost.ToString();
        //_spellRubyCostText.text = _personnage.SpellRubyCost.ToString();

        _extensionLogo.sprite = _personnage.Extension;
    }
}
