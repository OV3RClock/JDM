using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PassepasseDisplay : MonoBehaviour
{
    [SerializeField] private PassepasseSO _passepasse;

    [SerializeField] private Image _artwork;

    [SerializeField] private TMP_Text _nametext;

    [SerializeField] private TMP_Text _rubyText;

    [SerializeField] private TMP_Text _effectText;


    //[SerializeField] private Image _extensionText; LOGO

    //[SerializeField] private Image _rarity; A VOIR SELON TEMPLATE

    void Start()
    {
        _nametext.text = _passepasse.CardName;

        _artwork.sprite = _passepasse.Artwork;
        
        _rubyText.text = _passepasse.RubyCost.ToString();

        _effectText.text = _passepasse.Effect;
    }
}
