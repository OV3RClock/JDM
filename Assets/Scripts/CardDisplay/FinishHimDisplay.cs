using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FinishHimDisplay : MonoBehaviour
{
    [SerializeField] private FinishHimSO _finishHim;

    [SerializeField] private Image _artwork;

    [SerializeField] private TMP_Text _nametext;

    [SerializeField] private TMP_Text _rubyText;

    [SerializeField] private TMP_Text _effectText;


    //[SerializeField] private Image _extensionText; LOGO

    //[SerializeField] private Image _rarity; A VOIR SELON TEMPLATE

    void Start()
    {
        _nametext.text = _finishHim.CardName;

        _artwork.sprite = _finishHim.Artwork;
        
        _rubyText.text = _finishHim.RubyCost.ToString();

        _effectText.text = _finishHim.Effect;
    }
}
