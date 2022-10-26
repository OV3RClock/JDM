using System.Threading.Tasks;
using Unity.Services.Authentication;
using Unity.Services.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AuthenticationManager : MonoBehaviour 
{
    [SerializeField] private DiscordDataSO _discordData;
    
    private string playerId = "Not signed in";

    private string idToken = "";
    private string idProviderName = "";

    public async void LoginButton()
    {
        Debug.Log("Signing On...");

        await SignInWithOpenIdConnectAsync(idProviderName, idToken);

        playerId = AuthenticationService.Instance.PlayerId;

        Debug.Log("AuthenticationManager : playerId : " + playerId);
    }


    private async Task SignInWithOpenIdConnectAsync(string idProviderName, string idToken)
    {
        try
        {
            await AuthenticationService.Instance.SignInWithOpenIdConnectAsync(idProviderName, idToken);
            Debug.Log("SignIn is successful.");
        }
        catch (AuthenticationException ex)
        {
            // Compare error code to AuthenticationErrorCodes
            // Notify the player with the proper error message
            Debug.LogException(ex);
        }
        catch (RequestFailedException ex)
        {
            // Compare error code to CommonErrorCodes
            // Notify the player with the proper error message
            Debug.LogException(ex);
        }
    }

}