﻿using UnityEngine;
using System.Collections;

public class CustomShip : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void playLevel()
    {
        Application.LoadLevel("InGame");
    }
}
