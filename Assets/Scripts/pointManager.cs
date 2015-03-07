using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class pointManager : MonoBehaviour {

	
	public Text playerPoints;
	public Text playerInstruction;
	public GameObject commandManager;
	// Use this for initialization
	void Start () {
		playerPoints.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CorrectPlayerInput()
	{
		commandManager.GetComponent<commandManager> ().playing = false;
		playerPoints.text = ((int.Parse (playerPoints.text)) + 10).ToString();
		playerInstruction.color = Color.green;
		playerInstruction.text = "Nice Job!";
	}

	public void IncorrectPlayerInput()
	{
		playerInstruction.color = Color.red;
		playerInstruction.text = "Sorry, Try Again!";
	}
}
