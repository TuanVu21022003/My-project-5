using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private GameObject LevelSelection;
    [SerializeField] private Button buttonLevel;
    [SerializeField] private GameObject buttonBack;
    [SerializeField] private GameObject menuGame;
    private void Start()
    {
        buttonLevel.onClick.AddListener(() =>
        {
            ActiveLevelSelection();
            ActiveButtonBack();
            menuGame.SetActive(false);
        });
    }

    public void ActiveLevelSelection()
    {
        LevelSelection.SetActive(true);
    }

    public void DeactiveLevelSelection()
    {
        LevelSelection.SetActive(false);
    }

    public void ActiveButtonBack()
    {
        buttonBack.SetActive(true);
    }

    public void DeactiveButtonBack()
    {
        buttonBack.SetActive(false);
    }
}
