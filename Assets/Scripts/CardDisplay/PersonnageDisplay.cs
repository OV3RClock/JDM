using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PersonnageDisplay : CardDisplay
{
    public override object Data { set => _data = (PersonnageSO)value; }
    private PersonnageSO _data;

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
        if(_data == null) { return; }

        _cardNameText.text = _data.CardName;
        _effectText.text = _data.Effect;
        _rarityImage.sprite = _data.Rarity;
        _rubyRarityImage.sprite = _data.RubyRarity;

        _artwork.sprite = _data.Artwork;

        _rubyText.text = _data.RubyCost.ToString();
        //_spellRubyCostText.text = _personnage.SpellRubyCost.ToString();

        _extensionLogo.sprite = _data.Extension;
    }
}
