using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelItemUI : MonoBehaviour
{
    [SerializeField] private Text textLevel;
    [SerializeField] private Button buttonLevel;
    public void Init(string textIndex, Action<string> buttonLevelAction)
    {
        this.textLevel.text = "Level " + textIndex;
        buttonLevel.onClick.AddListener(() =>
        {
            buttonLevelAction.Invoke(textIndex);
        });
    }
}
