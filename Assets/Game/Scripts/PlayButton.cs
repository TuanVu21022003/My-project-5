using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    [SerializeField] Button buttonPlay;
    [SerializeField] CameraFollow cam;
    // Start is called before the first frame update
    void Start()
    {
        buttonPlay.interactable = false;
        buttonPlay.onClick.AddListener(() =>
        {
            cam.MoveCameraForward();
        });
    }
}
