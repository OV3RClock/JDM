using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Others/MenuPapersSO")]
public class MenuPapersSO : ScriptableObject
{
    [SerializeField] private Kop1SO[] _kop1s;
    public Kop1SO[] Kop1s { get => _kop1s; }

    [SerializeField] private string[] _descriptions;
    public string[] Descriptions { get => _descriptions; }
}
