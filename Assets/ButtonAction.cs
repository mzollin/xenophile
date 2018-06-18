﻿using GoogleARCore;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public class ButtonAction : MonoBehaviour {

    public GameObject obj;

    public string nextScene;

	// Use this for initialization
	void Start () {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
	}

    // Update is called once per frame
    void Update()
    {

    }

    void TaskOnClick()
    {
        Debug.Log("Button " + gameObject.name + " clicked.");
        StringHolder.name = obj.name;
        SceneManager.LoadScene(nextScene);
    }
}
