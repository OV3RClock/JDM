using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Kop1Display : MonoBehaviour
{
    [SerializeField] private Kop1SO _kop1;

    [SerializeField] private TMP_Text _cardNameText;
    [SerializeField] private TMP_Text _descriptionText;

    [SerializeField] private Image _descriptionImage;

    [SerializeField] private TMP_Text _manaText;
    [SerializeField] private TMP_Text _attText;
    [SerializeField] private TMP_Text _healthText;

    [SerializeField] private TMP_Text _archetypeText;
    //[SerializeField] private TMP_Text _healthText; LOGO ? NOM DE L'EXTENSION ?

    void Start()
    {
        _cardNameText.text = _kop1.CardName;
        _descriptionText.text = _kop1.Description;

        _descriptionImage.sprite = _kop1.Artwork;

        _manaText.text = _kop1.ManaCost.ToString();
        _attText.text = _kop1.Att.ToString();
        _healthText.text = _kop1.Health.ToString();

        _archetypeText.text = _kop1.Archetype.ToString();
    }
}
