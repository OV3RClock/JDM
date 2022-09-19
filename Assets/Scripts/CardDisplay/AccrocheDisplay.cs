using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AccrocheDisplay : MonoBehaviour
{
    [SerializeField] private AccrocheSO _accroche;

    [SerializeField] private Image _image;

    [SerializeField] private TMP_Text _cardNameText;

    [SerializeField] private TMP_Text _rubyText;

    [SerializeField] private TMP_Text _effectText;

    //[SerializeField] private Image _extensionText; LOGO

    //[SerializeField] private Image _rarity; A VOIR SELON TEMPLATE

    void Start()
    {
        _image.sprite = _accroche.Artwork;

        _cardNameText.text = _accroche.CardName;

        _rubyText.text = _accroche.RubyCost.ToString();

        _effectText.text = _accroche.Effect;
    }
}
