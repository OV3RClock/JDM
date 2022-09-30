using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PassepasseDisplay : CardDisplay
{
    public PassepasseSO Data;

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
        if(Data == null) { return; }

        _cardNameText.text = Data.CardName;
        _effectText.text = Data.Effect;
        _rarityImage.sprite = Data.RarityGem;
        _rubyRarityImage.sprite = Data.RubyRarity;

        _artwork.sprite = Data.Artwork;
        
        _rubyText.text = Data.RubyCost.ToString();

        _archetypeText.text = Data.Archetype.ToString();
        if (Data.Archetype == Archetype.TAMERE) { _archetypeText.text = "TA MERE"; }
        if (Data.Archetype == Archetype.NONE) { _archetypeText.text = ""; }
        _extensionLogo.sprite = Data.Extension;
    }
}
