using UnityEngine;

public class SceneBootstrap : MonoBehaviour
{
    [SerializeField] private SceneLoaderSO sceneLoader;

    public void Start()
    {
        sceneLoader.LoadSceneGroup(sceneLoader.GetSceneGroups()[0].name);
    }
}
