using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ClashDisplay : MonoBehaviour
{
    [SerializeField] private ClashSO _clash;

    [SerializeField] private TMP_Text _clashText;

    [SerializeField] private TMP_Text _rubyText;

    [SerializeField] private TMP_Text _effectText;

    [SerializeField] private TMP_Text _achetypeText;


    //[SerializeField] private Image _extensionText; LOGO

    //[SerializeField] private Image _rarity; A VOIR SELON TEMPLATE

    void Start()
    {
        _clashText.text = _clash.ClashText;

        _rubyText.text = _clash.RubyCost.ToString();

        _effectText.text = _clash.Effect;

        _achetypeText.text = _clash.Archetype;
    }
}
