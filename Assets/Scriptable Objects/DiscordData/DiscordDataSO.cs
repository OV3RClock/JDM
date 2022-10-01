using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName ="Others/NetworkDataSO")]
public class DiscordDataSO : ScriptableObject
{
    #region Variables

    [SerializeField] private long _appClientID;
    public long AppClientID { get => _appClientID; set => _appClientID = value; }

    private Discord.Discord _instance;
	public Discord.Discord Instance { get => _instance; set => _instance = value; }

    #region UserData

    private string _userName;
    public string UserName { get => _userName; }

    private string _userDiscriminator;
    public string UserDiscriminator { get => _userDiscriminator; }

    private long _userId;
    public long UserId { get => _userId; }

    [HideInInspector]
    public Sprite _userSprite;
    public Sprite UserSprite { get => _userSprite; }

    #endregion

    #endregion

    #region Functions

    public void Init()
    {
        _userName = null;
        _userDiscriminator = null;
        _userId = -1;
        _userSprite = null;

        SetInstance();
        GetCurrentUser();
    }

    private void SetInstance()
    {
        _instance = new Discord.Discord(_appClientID, (System.UInt64)Discord.CreateFlags.Default);
    }

    public void GetCurrentUser()
    {
        var userManager = _instance.GetUserManager();
        userManager.OnCurrentUserUpdate += () => {
            var currentUser = userManager.GetCurrentUser();

            _userName = currentUser.Username;
            _userDiscriminator = currentUser.Discriminator;
            _userId = currentUser.Id;
        };
    }

    public void GetCurrentUserSprite()
    {
        var imageManager = _instance.GetImageManager();
        var handle = new Discord.ImageHandle()
        {
            Id = _userId,
            Size = 1024
        };

        imageManager.Fetch(handle, false, (result, handle) =>
        {
            if (result == Discord.Result.Ok)
            {
                var texture = imageManager.GetTexture(handle);
                _userSprite = Sprite.Create(texture, new Rect(0, 0, texture.width, -texture.height), new Vector2(0.5f,0.5f));
            }
        });
    }

    public void SetRichPresence()
    {
        if (_instance == null) { Debug.Log("Instance null"); return; }
        Discord.ActivityManager activityManager = _instance.GetActivityManager();
        Discord.Activity activity = new Discord.Activity
        {
            State = "Still Testing",
            Details = "Bigger Test"
        };

        activityManager.UpdateActivity(activity, (res) =>
        {
            if (res == Discord.Result.Ok) { Debug.Log("Discord RP updated sucessfully"); }
        });
    }


    #endregion
}
