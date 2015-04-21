using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameManager : MonoBehaviour {
	
	public string currentLevelName;
	public Text playerPoints;
//	public Text playerInstruction;
//	public GameObject commandManager;
	public int gamePoints;
	public GameObject userProfile;
	public bool paused;
	public string[] gameNames = new string[2];

	// Use this for initialization
	void Start () {
		paused = false;
		userProfile = GameObject.Find("User_Profile");
		gamePoints = (int)userProfile.GetComponent<userProfile>().totalPoints;
		playerPoints.text = gamePoints.ToString ();
		Invoke("EndKnightGame", 45f);
		Invoke ("EndFruitGame", 45f);
	}
	
	// Update is called once per frame
	void Update () {
		playerPoints.text = gamePoints.ToString ();
	}
	
	void EndKnightGame() {
		if (currentLevelName == "MainLevel_FlyingKnights") {
			userProfile = GameObject.Find("User_Profile");
			userProfile.GetComponent<userProfile>().totalPoints += gamePoints;
			if(userProfile.GetComponent<userProfile>().playAll){
				Application.LoadLevel ("MainLevel_Elevator");
				currentLevelName = "MainLevel_Elevator";
			}
			else{
				Application.LoadLevel ("StageSelectionScreen");
				currentLevelName = "StageSelectionScreen";
			}
		}
	}
	
	public void EndElevatorGame() {
		if (currentLevelName == "MainLevel_Elevator") {
			userProfile = GameObject.Find("User_Profile");
			userProfile.GetComponent<userProfile>().totalPoints += gamePoints;
			if(userProfile.GetComponent<userProfile>().playAll){
				if(userProfile.GetComponent<userProfile>().right_hand && userProfile.GetComponent<userProfile>().left_hand){
					Application.LoadLevel("DualPong");
					currentLevelName = "DualPong";
				}
				else if(userProfile.GetComponent<userProfile>().head){
					Application.LoadLevel("MainLevel_Fruits");
					currentLevelName = "MainLevel_Fruits";
				}
				else{
					Application.LoadLevel("MainLevel_FindTreasure");
					currentLevelName = "MainLevel_FindTreasure";
				}
			}
			else{
				Application.LoadLevel ("StageSelectionScreen");
				currentLevelName = "StageSelectionScreen";
			}
		}
	}
	
	public void EndPongGame() {
		if (currentLevelName == "DualPong") {
			userProfile = GameObject.Find("User_Profile");
			userProfile.GetComponent<userProfile>().totalPoints += gamePoints;
			if(userProfile.GetComponent<userProfile>().playAll){
				if(userProfile.GetComponent<userProfile>().head){
					Application.LoadLevel("MainLevel_Fruits");
					currentLevelName = "MainLevel_Fruits";
				}
				else{
					Application.LoadLevel("MainLevel_FindTreasure");
					currentLevelName = "MainLevel_FindTreasure";
				}
			}
			else{
				Application.LoadLevel ("StageSelectionScreen");
				currentLevelName = "StageSelectionScreen";
			}
		}
	}
	
	void EndFruitGame() {
		if (currentLevelName == "MainLevel_Fruits") {
			userProfile = GameObject.Find("User_Profile");
			userProfile.GetComponent<userProfile>().totalPoints += gamePoints;
			if(userProfile.GetComponent<userProfile>().playAll){
				if(userProfile.GetComponent<userProfile>().right_hand || userProfile.GetComponent<userProfile>().left_hand){
					Application.LoadLevel("MainLevel_FindTreasure");
					currentLevelName = "MainLevel_FindTreasure";
				}
				else{
					Application.LoadLevel("StageSelectionScreen");
					currentLevelName = "StageSelectionScreen";
				}
			}
			else{
				Application.LoadLevel ("StageSelectionScreen");
				currentLevelName = "StageSelectionScreen";
			}
		}
	}
	
	public void EndTreasureGame() {
		if (currentLevelName == "MainLevel_FindTreasure") {
			userProfile = GameObject.Find("User_Profile");
			userProfile.GetComponent<userProfile>().totalPoints += gamePoints;
			Application.LoadLevel ("StageSelectionScreen");
			currentLevelName = "StageSelectionScreen";
		}
	}

	public void chooseGame() {
		Application.LoadLevel (gameNames [Random.Range (0, 1)]);
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
