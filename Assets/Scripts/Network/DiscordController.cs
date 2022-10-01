using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discord;

public class DiscordController : MonoBehaviour
{
	[SerializeField] private DiscordDataSO _discordData;
	
	private void Start()
	{
		_discordData.Init();
	}

	private void Update()
	{
		if (_discordData.UserSprite == null) { _discordData.SaveUserSprite(); }

		if(_discordData.Refresh)
        {
			_discordData.UserSprite = _discordData.LoadUserSprite("userSprite");
			_discordData.Refresh = false;
		}

		_discordData.Instance.RunCallbacks();
	}
}
