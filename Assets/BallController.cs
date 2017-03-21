﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	private float visiblePosZ = -6.5f;
	private GameObject gameoverText;

	// Use this for initialization
	void Start () {
		this.gameoverText = GameObject.Find ("GameOverText");
		
	}
	
	// Update is called once per frame
	void Update () {

		if(transform.position.z < visiblePosZ ) {
			gameoverText.GetComponent<Text>().text = "Game Over";
		}
	}
}