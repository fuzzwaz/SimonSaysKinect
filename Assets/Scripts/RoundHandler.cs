using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RoundHandler : MonoBehaviour {

	int currentRound;
	int maxRound;
	public string[] correctButtonOrder = new string[5];
	public string[] currentButtonsPressed = new string[5];

	// Use this for initialization
	void Start () {

		currentRound = 1;
		maxRound = 5;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void NextRound(){
		currentRound++;
	}
}
