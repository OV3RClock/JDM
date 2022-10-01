using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(menuName = "Others/SceneLoaderSO")]
public class SceneLoaderSO : ScriptableObject
{
	[SerializeField] private List<SceneGroup> sceneGroups;

	public void LoadSceneGroup(string groupName)
	{
		var scenes = sceneGroups.Find(sceneGroup => sceneGroup.name == groupName);
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
}