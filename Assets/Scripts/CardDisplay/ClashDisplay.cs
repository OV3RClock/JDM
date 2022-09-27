using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ClashDisplay : CardDisplay
{
    public override object Data { set => _data = (ClashSO)value; }
    private ClashSO _data;

    [SerializeField] private TMP_Text _clashText;
    [SerializeField] private TMP_Text _effectText;
    [SerializeField] private Image _rarityImage;
    [SerializeField] private Image _rubyRarityImage;

    [SerializeField] private TMP_Text _rubyText;

    [SerializeField] private TMP_Text _achetypeText;
    [SerializeField] private Image _extensionLogo;

    void Start()
    {
        if(_data == null) { return; }

        _clashText.text = _data.ClashText;
        _effectText.text = _data.Effect;

        _rubyText.text = _data.RubyCost.ToString();

        _achetypeText.text = _data.Archetype;
        _extensionLogo.sprite = _data.Extension;
    }
}
