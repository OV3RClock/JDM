using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Others/NetworkDataSO")]
public class DiscordDataSO : ScriptableObject
{
    #region Variables

    public Discord.Discord Instance;

    [SerializeField] private long _appClientID;
    public long AppClientID { get => _appClientID; set => _appClientID = value; }

    #endregion

    #region Functions



    #endregion
}
