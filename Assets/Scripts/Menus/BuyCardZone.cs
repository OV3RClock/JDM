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

    public int _amount = 1;
    private bool _refresh = false;

    private void Start()
    {
        _amountText.text = _amount.ToString();
        _costText.text = (_amount * _cardShop._pages[_cardShop._index].Extension.PackCost).ToString();
    }

    private void Update()
    {
        if (!_refresh) { return; }

        _amountText.text = _amount.ToString();
        _costText.text = (_amount * _cardShop._pages[_cardShop._index].Extension.PackCost).ToString();
    }

    public void Button(int _int)
    {
        _amount += _int;
        if(_amount > 10) { _amount = 10; return; }
        if (_amount < 1) { _amount = 1; return; }
        _refresh = true;
    }
}
