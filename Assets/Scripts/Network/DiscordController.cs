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
		if (_discordData.UserSprite == null) { _discordData.GetCurrentUserSprite(); }
		_discordData.Instance.RunCallbacks();
	}
}
