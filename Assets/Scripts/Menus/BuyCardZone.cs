using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuyCardZone : MonoBehaviour
{
    [SerializeField] private CardShopMenu _cardShop;
    [SerializeField] private TMP_Text _amountText;
    [SerializeField] private TMP_Text _costText;
    [SerializeField] private Button _buyButton;

    private int _amount = 0;
    private bool _refresh = false;

    private void Start()
    {
        _refresh = true;
    }

    private void Update()
    {
        if (!_refresh) { return; }

        _amountText.text = _amount.ToString();
        _costText.text = (_amount * _cardShop.Extensions[_cardShop._index].PackCost).ToString();
    }

    public void Button(int _int)
    {
        _amount += _int;
        if(_amount > 10) { _amount = 10; return; }
        if (_amount < 0) { _amount = 0; return; }
        _refresh = true;
    }
}
