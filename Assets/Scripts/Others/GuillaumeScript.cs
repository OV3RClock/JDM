using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GuillaumeScript : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private GuillaumeDialogueSO _data;
    private bool refresh = false;

    void Start()
    {
        int rand = UnityEngine.Random.Range(0, _data.Dialogues.Length);
        _text.text = _data.Dialogues[rand];
    }

    void Update()
    {
        if (!refresh) { return; }

        int rand = UnityEngine.Random.Range(0, _data.Dialogues.Length);
        _text.text = _data.Dialogues[rand];

        refresh = false;
    }

    public void NextDialogue()
    {
        refresh = true;
    }
}
