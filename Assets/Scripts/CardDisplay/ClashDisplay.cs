using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ClashDisplay : CardDisplay
{
    public ClashSO Data;

    [SerializeField] private TMP_Text _clashText;
    [SerializeField] private TMP_Text _effectText;
    [SerializeField] private Image _rarityImage;
    [SerializeField] private Image _rubyRarityImage;

    [SerializeField] private TMP_Text _rubyText;

    [SerializeField] private TMP_Text _achetypeText;
    [SerializeField] private Image _extensionLogo;

    void Start()
    {
        if(Data == null) { return; }

        _clashText.text = Data.ClashText;
        _effectText.text = Data.Effect;

        _rubyText.text = Data.RubyCost.ToString();

        _achetypeText.text = Data.Archetype;
        _extensionLogo.sprite = Data.Extension;
    }
}
