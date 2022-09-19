using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FinishHimDisplay : MonoBehaviour
{
    [SerializeField] private FinishHimSO _finishHim;

    [SerializeField] private TMP_Text _clashText;

    [SerializeField] private TMP_Text _rubyText;

    [SerializeField] private TMP_Text _effectText;

    [SerializeField] private TMP_Text _achetypeText;


    //[SerializeField] private Image _extensionText; LOGO

    //[SerializeField] private Image _rarity; A VOIR SELON TEMPLATE

    void Start()
    {
        //_clashText.text = _finishHim.ClashText;

        _rubyText.text = _finishHim.RubyCost.ToString();

        //_effectText.text = _finishHim.Effect;

        _achetypeText.text = _finishHim.Archetype;
    }
}
