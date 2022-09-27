using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ClashDisplay : MonoBehaviour
{
    [SerializeField] public ClashSO _clash;

    [SerializeField] private TMP_Text _clashText;
    [SerializeField] private TMP_Text _effectText;
    [SerializeField] private Image _rarityImage;
    [SerializeField] private Image _rubyRarityImage;

    [SerializeField] private TMP_Text _rubyText;

    [SerializeField] private TMP_Text _achetypeText;
    [SerializeField] private Image _extensionLogo;

    void Start()
    {
        if(_clash == null) { return; }

        _clashText.text = _clash.ClashText;
        _effectText.text = _clash.Effect;

        _rubyText.text = _clash.RubyCost.ToString();

        _achetypeText.text = _clash.Archetype;
        _extensionLogo.sprite = _clash.Extension;
    }
}
