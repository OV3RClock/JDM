using Unity.Services.Authentication;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AuthenticationManager : MonoBehaviour 
{
    private string playerId = "Not signed in";

    public async void LoginButton()
    {
        Debug.Log("Signing On...");

        await AuthenticationService.Instance.SignInAnonymouslyAsync();
        playerId = AuthenticationService.Instance.PlayerId;

        Debug.Log("AuthenticationManager : playerId : " + playerId);
    }

}