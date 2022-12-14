using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionScript : MonoBehaviour
{
    [SerializeField] TransitionSO _transitionSO;
    [SerializeField] SceneLoaderSO _sceneLoaderSO;
    private Animator _animator;

    private static readonly int Start1 = Animator.StringToHash("Start");

    private void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if (_transitionSO.StartTransition == true)
        {
            StartCoroutine(Transition());
            _transitionSO.StartTransition = false;
        }
    }

    private IEnumerator Transition()
    {
        _animator.SetTrigger(Start1);
        yield return new WaitForSeconds(0.5f);
        _sceneLoaderSO.LoadSceneGroup(_transitionSO.SceneGroupToLoad);
    }
}
