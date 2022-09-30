using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discord;

public class DiscordController : MonoBehaviour
{
	[SerializeField] private DiscordDataSO _discordData;
	

	void Start()
	{
		_discordData.Instance = new Discord.Discord(_discordData.AppClientID, (System.UInt64)Discord.CreateFlags.Default);
		var activityManager = _discordData.Instance.GetActivityManager();
		var activity = new Discord.Activity
		{
			State = "Still Testing",
			Details = "Bigger Test"
		};
		activityManager.UpdateActivity(activity, (res) =>
		{
			if (res == Discord.Result.Ok)
			{
				Debug.Log("Everything is fine!");
			}
		});
		
	}

	void Update()
	{
		_discordData.Instance.RunCallbacks();
	}
}
