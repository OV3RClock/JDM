using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiscordUserDisplay : MonoBehaviour
{
    [SerializeField] private DiscordDataSO _discordData;
    [SerializeField] private TMP_Text _usernameText;
    [SerializeField] private Image _image;

    private void Start()
    {
        if(_discordData == null) { return; }
        _usernameText.text = _discordData.UserName;
        _image.sprite = _discordData.UserSprite;
    }
}
