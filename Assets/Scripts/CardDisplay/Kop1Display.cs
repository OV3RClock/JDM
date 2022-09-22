using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Kop1Display : MonoBehaviour
{
    [SerializeField] private Kop1SO _kop1;

    [SerializeField] private Image _image;

    [SerializeField] private TMP_Text _cardNameText;

    [SerializeField] private TMP_Text _rubyText;
    [SerializeField] private TMP_Text _stcText;
    [SerializeField] private TMP_Text _resText;

    [SerializeField] private TMP_Text _effectText;
    [SerializeField] private TMP_Text _archetypeText;

    //[SerializeField] private Image _extensionText; LOGO

    //[SerializeField] private Image _rarity; A VOIR SELON TEMPLATE

    void Start()
    {
        _image.sprite = _kop1.Artwork;

        _cardNameText.text = _kop1.CardName;

        _rubyText.text = _kop1.RubyCost.ToString();
        _stcText.text = _kop1.Stc.ToString();
        _resText.text = _kop1.Res.ToString();

        _effectText.text = _kop1.Effect;

        _archetypeText.text = _kop1.Archetype.ToString();
    }
}
