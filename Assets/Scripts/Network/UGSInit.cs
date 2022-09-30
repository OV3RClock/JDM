using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Authentication;

public class UGSInit : MonoBehaviour
{
    async void Start()
    {
        await UnityServices.InitializeAsync();
        Debug.Log("UGSInit : Unity Services State : " + UnityServices.State);
    }
}
