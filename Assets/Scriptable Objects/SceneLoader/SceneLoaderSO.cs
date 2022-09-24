using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(menuName = "Others/SceneLoaderSO")]
public class SceneLoaderSO : ScriptableObject
{
	[SerializeField] private List<SceneGroup> _sceneGroups;

	public void LoadSceneGroup(string groupName)
	{
		SceneGroup scenes = _sceneGroups.Find(sceneGroup => sceneGroup.name == groupName);
		LoadScenes(scenes.scenesToLoad);
	}

	private static void LoadScenes(ICollection<string> scenes)
	{
		int count = 0;
		List<string> sceneLoaded = GetActiveSceneName();
		
		foreach (string sceneName in sceneLoaded.Where(sceneName => !scenes.Contains(sceneName)))
		{
			SceneManager.UnloadSceneAsync(sceneName);
		}

		foreach (string sceneName in scenes.Where(sceneName => !sceneLoaded.Contains(sceneName)))
		{
			count++;
			AsyncOperation op = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
			op.completed += (_) => count--;
		}
	}

	private static List<string> GetActiveSceneName()
	{
		List<string> scenesName = new List<string>();

		for (int i = 0; i < SceneManager.sceneCount; i++)
		{
			scenesName.Add(SceneManager.GetSceneAt(i).name);
		}

		return scenesName;
	}

	public List<SceneGroup> GetSceneGroups()
	{
		return _sceneGroups;
	}
}

[Serializable]
public struct SceneGroup
{
	public string name;
	public List<string> scenesToLoad;
}