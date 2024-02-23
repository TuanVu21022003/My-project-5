using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    [SerializeField] private GameObject LevelSelection;
    [SerializeField] private Button buttonBack;
    [SerializeField] private GameObject menuGame;

    private void Start()
    {
        gameObject.SetActive(false);
        buttonBack.onClick.AddListener(() =>
        {
            DeactiveLevelSelection();
            gameObject.SetActive(false);
            menuGame.SetActive(true);
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
}
