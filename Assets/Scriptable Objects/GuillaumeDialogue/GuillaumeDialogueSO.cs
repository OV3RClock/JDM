using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Others/GuillaumeDialogueSO")]
public class GuillaumeDialogueSO : ScriptableObject
{
    [SerializeField] private string[] _dialogues;
    public string[] Dialogues { get => _dialogues; }
}
