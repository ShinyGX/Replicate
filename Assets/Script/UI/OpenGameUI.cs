﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class OpenGameUI : MonoBehaviour {

    public Button openGame;
    public Button help;

    public GameObject helpUI;
    // Use this for initialization
    void Start()
    {
        openGame.onClick.AddListener(() =>
        {
            EditorSceneManager.LoadScene("MainScene");
        });

        help.onClick.AddListener(() =>
        {
            helpUI.SetActive(true);
        });
    }
	

}
