using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PersonnageDisplay : MonoBehaviour
{
    [SerializeField] private PersonnageSO _personnage;

    [SerializeField] private Image _image;

    [SerializeField] private TMP_Text _cardNameText;

    [SerializeField] private TMP_Text _rubyText;
    [SerializeField] private TMP_Text _spellRubyCostText;

    [SerializeField] private TMP_Text _effectText;

    //[SerializeField] private Image _extensionText; LOGO

    //[SerializeField] private Image _rarity; A VOIR SELON TEMPLATE

    void Start()
    {
        _image.sprite = _personnage.Artwork;

        _cardNameText.text = _personnage.CardName;

        _rubyText.text = _personnage.RubyCost.ToString();
        _spellRubyCostText.text = _personnage.SpellRubyCost.ToString();

        _effectText.text = _personnage.Effect;
    }
}
