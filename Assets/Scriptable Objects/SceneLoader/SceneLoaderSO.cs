using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(menuName = "Others/SceneLoader")]
public class SceneLoaderSO : ScriptableObject
{
    [SerializeField] private SceneGroup alwaysLoaded;
    [SerializeField] private List<SceneGroup> sceneGroups;

    public void LoadSceneGroup(string groupName)
    {
        var scenes = alwaysLoaded + sceneGroups.Find(sceneGroup => sceneGroup.name == groupName);
        LoadScenes(scenes.scenesToLoad);
    }

    private static void LoadScenes(ICollection<string> scenes)
    {
        var count = 0;
        var sceneLoaded = GetActiveSceneName();

        foreach (var sceneName in sceneLoaded.Where(sceneName => !scenes.Contains(sceneName)))
        {
            SceneManager.UnloadSceneAsync(sceneName);
        }

        foreach (var sceneName in scenes.Where(sceneName => !sceneLoaded.Contains(sceneName)))
        {
            count++;
            var op = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
            op.completed += (_) => count--;
        }
    }

    private static List<string> GetActiveSceneName()
    {
        var scenesName = new List<string>();

        for (var i = 0; i < SceneManager.sceneCount; i++)
        {
            scenesName.Add(SceneManager.GetSceneAt(i).name);
        }

        return scenesName;
    }

    public List<SceneGroup> GetSceneGroups()
    {
        return sceneGroups;
    }
}

[Serializable]
public struct SceneGroup
{
    public string name;
    public List<string> scenesToLoad;

    public static SceneGroup operator +(SceneGroup self, SceneGroup other)
    {
        var mySceneGroup = new SceneGroup
        {
            scenesToLoad = new List<string>()
        };

        mySceneGroup.scenesToLoad.AddRange(self.scenesToLoad);
        mySceneGroup.scenesToLoad.AddRange(other.scenesToLoad);

        return mySceneGroup;
    }
}