﻿using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void Die () {
		Destroy (gameObject);
		GameObject paddleObject = GameObject.Find ("PaddleLeft");
		PaddleLeftScript paddleLeftScript = paddleObject.GetComponent<PaddleLeftScript> ();
		paddleLeftScript.SpawnBall ();
	}
}
