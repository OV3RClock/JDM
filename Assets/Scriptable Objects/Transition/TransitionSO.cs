using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Others/TransitionSO")]
public class TransitionSO : ScriptableObject
{
    private bool _startTransition = false;
    public bool StartTransition { get => _startTransition; set => _startTransition = value; }

    private string _sceneGroupToLoad;
    public string SceneGroupToLoad { get => _sceneGroupToLoad; }

    public void Transition(string groupName)
    {
        _startTransition = true;
        _sceneGroupToLoad = groupName;
    }

    public void CloseApplication()
    {
        Application.Quit();
    }
}
