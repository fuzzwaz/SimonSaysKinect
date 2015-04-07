﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameManager : MonoBehaviour {
	
	public string currentLevelName;
	public Text playerPoints;
	public Text playerInstruction;
	public GameObject commandManager;
	public int gamePoints;
	public GameObject userProfile;

	// Use this for initialization
	void Start () {
		userProfile = GameObject.Find("User_Profile");
		gamePoints = userProfile.GetComponent<userProfile>().totalPoints;
		playerPoints.text = gamePoints.ToString ();
		Invoke("EndKnightGame", 20f);
	}
	
	// Update is called once per frame
	void Update () {
		playerPoints.text = gamePoints.ToString ();
	}
	
	void EndKnightGame() {
		if (currentLevelName == "MainLevel_FlyingKnights") {
			userProfile = GameObject.Find("User_Profile");
			userProfile.GetComponent<userProfile>().totalPoints += gamePoints;
			Application.LoadLevel ("MainLevel_Elevator");
			currentLevelName = "MainLevel_Elevator";
		}
	}
	
	public void EndElevatorGame() {
		if (currentLevelName == "MainLevel_Elevator") {
			userProfile = GameObject.Find("User_Profile");
			userProfile.GetComponent<userProfile>().totalPoints += gamePoints;
			Application.LoadLevel ("TitleScreen");
			currentLevelName = "TitleScreen";
		}
	}
//
//	public void CorrectPlayerInput()
//	{
//		commandManager.GetComponent<commandManager> ().playing = false;
//		playerPoints.text = ((int.Parse (playerPoints.text)) + 10).ToString();
//		playerInstruction.color = Color.green;
//		playerInstruction.text = "Nice Job!";
//	}
//
//	public void IncorrectPlayerInput()
//	{
//		playerInstruction.color = Color.red;
//		playerInstruction.text = "Sorry, Try Again!";
//	}
}