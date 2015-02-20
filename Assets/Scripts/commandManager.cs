using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class commandManager : MonoBehaviour {

	int commandSize;
	float timer = 0.0f;
	public Text playerInstruction;
	public GameObject[] commands;
	public GameObject pointManager;


	// Use this for initialization
	void Start () {
		commandSize = commands.Length;
		if (pointManager == null)
		{pointManager = GameObject.Find("Point_Manager");}
		GiveInstruction();
	}
	
	// Update is called once per frame
	void Update () {

		//Correct Input has been recieved, update the points 
		if (Input.GetKeyDown(KeyCode.C))
		{pointManager.GetComponent<pointManager>().CorrectPlayerInput();}

		//Incorrect Input has been recieved, update the points
		if (Input.GetKeyDown(KeyCode.I))
		{pointManager.GetComponent<pointManager>().IncorrectPlayerInput();}

		timer += Time.deltaTime;

		if (timer > 10.0f)
		{
			timer = 0;
			GiveInstruction();
		}
	}

	public void GiveInstruction ()
	{
		int instructionNum = Random.Range (0,commandSize - 1);
		playerInstruction.color = Color.magenta;
		playerInstruction.text = commands[instructionNum].GetComponent<commandVariables>().displayText;

	}
}
