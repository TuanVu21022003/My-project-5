using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectionUI : MonoBehaviour
{
    [SerializeField] private LevelItemUI buttonLevelPrefab;
    [SerializeField] private Transform parentPositon;
    [SerializeField] private LevelOS levelData;

    [SerializeField] private GameObject mapCurrent = null;
    [SerializeField] private GameObject levelSelection;
    [SerializeField] private GameObject buttonBack;
    [SerializeField] private GameObject buttonPlay;

    private string levelIndexCurrent ;
    private void Start()
    {
        gameObject.SetActive(false);
        SelectLevelList();
    }

    public void SelectLevelItem(string textIndex)
    {
        LevelItemUI levelItem = Instantiate(buttonLevelPrefab, parentPositon);
        levelItem.Init(textIndex, OnHandleButtonLevel);
    }

    public void SelectLevelList()
    {
        for (int i = 0; i < levelData.list.Count; i++)
        {
            SelectLevelItem(levelData.list[i].levelIndex.ToString());
        }
    }

    public void OnHandleButtonLevel(string textIndex)
    {
        levelSelection.SetActive(false);
        if(!textIndex.Equals(levelIndexCurrent) || mapCurrent == null)
        {
            GameObject mapPrefab = Resources.Load<GameObject>($"{PathConstant.PATH_MAP}Map_{textIndex}");
            Destroy(mapCurrent);
            mapCurrent = Instantiate(mapPrefab);
            levelIndexCurrent = textIndex;
        }
        buttonBack.SetActive(false);
        buttonPlay.GetComponent<Button>().interactable = true;
    }
}
