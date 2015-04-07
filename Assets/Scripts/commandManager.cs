using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class commandManager : MonoBehaviour {

	int commandSize;
	float timer = 0.0f;
	public string playerLabel; 
	public Text playerInstruction;
	public GameObject[] commands;
	public GameObject pointManager;
	public bool playing = true;


	// Use this for initialization
	void Start () {
		playing = true;
		commandSize = commands.Length;
		if (pointManager == null)
		{pointManager = GameObject.Find("Point_Manager");}
		GiveInstruction();
	}
	
	// Update is called once per frame
	void Update () {

//		//Correct Input has been recieved, update the points 
//		if (Input.GetKeyDown(KeyCode.C))
//		{pointManager.GetComponent<gameManager>().CorrectPlayerInput();}
//
//		//Incorrect Input has been recieved, update the points
//		if (Input.GetKeyDown(KeyCode.I))
//		{pointManager.GetComponent<gameManager>().IncorrectPlayerInput();}

		if (playing == false) {
			timer += Time.deltaTime;
		}
		if (timer > 5.0f) {
			playing = true;
			timer = 0.0f;
			GiveInstruction();
		}


	}

	public void GiveInstruction ()
	{
		int instructionNum = Random.Range (0,commandSize);
		playerInstruction.color = Color.magenta;
		playerLabel = commands [instructionNum].GetComponent<commandVariables> ().name;
		playerInstruction.text = commands[instructionNum].GetComponent<commandVariables>().displayText;
		Invoke ("TakeAwayInstruction", 8f);
	}

	public void TakeAwayInstruction(){
		playerInstruction.text = "";
	}
}
