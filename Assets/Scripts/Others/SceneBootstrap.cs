using UnityEngine;


public class SceneBootstrap : MonoBehaviour
{
    [SerializeField] private SceneLoaderSO sceneLoader;

    public void Start()
    {
        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 0;
        sceneLoader.LoadSceneGroup(sceneLoader.GetSceneGroups()[0].name);
    }
}
