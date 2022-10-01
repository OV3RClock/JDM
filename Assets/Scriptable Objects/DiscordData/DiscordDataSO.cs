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

    [SerializeField] private Sprite _stcIcon;

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
    public Sprite UserSprite { get => _userSprite; set => _userSprite = value; }

    #endregion

    #endregion

    #region Functions

    public void Init()
    {
        SetInstance();

        if (!PlayerPrefs.HasKey("userName")) { SaveUserInfo(); }

        _userName = PlayerPrefs.GetString("userName");
        _userDiscriminator = PlayerPrefs.GetString("userDiscriminator");
        _userId = PlayerPrefs.GetInt("userId");

        if (!PlayerPrefs.HasKey("userSprite")) { SaveUserSprite(); }

        _userSprite = LoadUserSprite("userSprite");

        //SetRichPresence();

        GetOauth2Token();
    }

    private void SetInstance()
    {
        _instance = new Discord.Discord(_appClientID, (System.UInt64)Discord.CreateFlags.Default);
    }

    public void SaveUserInfo()
    {
        var userManager = _instance.GetUserManager();
        userManager.OnCurrentUserUpdate += () => {
            var currentUser = userManager.GetCurrentUser();

            _userName = currentUser.Username;
            PlayerPrefs.SetString("userName", _userName);

            _userDiscriminator = currentUser.Discriminator;
            PlayerPrefs.SetString("userDiscriminator", _userDiscriminator);

            _userId = currentUser.Id;
            PlayerPrefs.SetInt("userId", (int)_userId);

            PlayerPrefs.Save();
        };
    }

    public void SaveUserSprite()
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
                Texture2D texture = imageManager.GetTexture(handle);
                byte[] data = texture.EncodeToPNG();
                string base64Tex = System.Convert.ToBase64String(data);

                if(base64Tex != null)
                {
                    PlayerPrefs.SetString("userSprite", base64Tex);
                    PlayerPrefs.Save();
                }
            }
        });
    }

    public Sprite LoadUserSprite(string variable)
    {
        string base64Tex = PlayerPrefs.GetString(variable);

        if (!string.IsNullOrEmpty(base64Tex))
        {
            byte[] texByte = System.Convert.FromBase64String(base64Tex);
            Texture2D tex = new Texture2D(2,2);

            if (tex.LoadImage(texByte))
            {
                return Sprite.Create(tex, new Rect(0, 0, tex.width, -tex.height), new Vector2(0.5f, 0.5f));
            }
        }
        return null;
    }

    public void SetRichPresence()
    {
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

    public void GetOauth2Token()
    {
        _instance.GetApplicationManager().GetOAuth2Token((Discord.Result result, ref Discord.OAuth2Token token) =>
        {
            if (result == Discord.Result.Ok)
            {
                //Debug.Log(token.AccessToken);
                
                // You may now use this token against Discord's HTTP API
            }
        });
    }

    #endregion
}
