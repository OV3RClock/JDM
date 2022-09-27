using UnityEngine;
using UnityEngine.Audio;

public class SceneBootstrap : MonoBehaviour
{
    [SerializeField] private SceneLoaderSO sceneLoader;
    [SerializeField] private AudioMixer _mixer;

    public void Start()
    {
        sceneLoader.LoadSceneGroup(sceneLoader.GetSceneGroups()[0].name);

        if(PlayerPrefs.HasKey("volume"))
        {
            _mixer.SetFloat("volume", Mathf.Log10(PlayerPrefs.GetFloat("volume")) * 20);
        }
        
    }
}
