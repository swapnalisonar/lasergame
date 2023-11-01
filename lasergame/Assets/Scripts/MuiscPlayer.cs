﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuiscPlayer : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        SetUpSingleton();
	}
	
    private void SetUpSingleton()
    {
        if(FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
