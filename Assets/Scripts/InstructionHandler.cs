using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InstructionHandler : MonoBehaviour {

	//The Instruction Handler determines the overall correct sequence of 5 colors that the player will
	//		need to press during the game. It sets these colors onto the actual InstructionShape 
	//		gameobjects that show up on the bottom of the screen for the player to know what they will
	//		need to press.
	//It also manages the different "phases" of each round by handling when the InstructionShapes will
	//		appear for the player and when the player can interact with buttons using the handColliders.

	//This is a reference to this game's round handler
	public RoundHandler roundHandler;
	//This array holds the gameobjects of the squares that show up at the bottom of the screen
	// 		to tell the player which buttons they should press. See "InstructionShape" gameobjects in game.
	public GameObject[] instructionShapes = new GameObject[5];
	//This array holds the actual colored materials that will be placed on each of the gameobjects
	//		in instructionShapes
	public Material[] mats = new Material[5];
	//This array is a reference to the 5 buttons that the player will be pressing during the game
	public ElevatorButton[] buttons = new ElevatorButton[5];
	//These are references to the hand colliders in the game.
	public GameObject handColliderR;
	public GameObject handColliderL;

	public int currentRound;
	int maxRound;
	//This array holds the correct overall sequence of 5 colors that will be used during
	// 		 the whole game. The Instruction Handler will set these values. (ALSO IN ROUNDHANDLER)
	string[] correctButtonOrder;

	// Use this for initialization
	void Start () {
		int pickRandomColorIndex = -1;
		correctButtonOrder = new string[5];

		//On start this script randomly chooses the sequence of colors that the player will 
		//		have to press during this game

		//buttonChoices holds the strings of the possible button colors for the sequence
		List<string> buttonChoices = new List<string>();
		buttonChoices.Add ("red");
		buttonChoices.Add ("green");
		buttonChoices.Add ("blue");
		buttonChoices.Add ("orange");
		buttonChoices.Add ("purple");
		//matList holds the actual color materials that will be applied to the "InstructionShape"
		//		gameObjects. mat0 is a red material, mat1 is a green material, and so on.
		List<Material> matList = new List<Material>();
		matList.Add (mats[0]);
		matList.Add (mats[1]);
		matList.Add (mats[2]);
		matList.Add (mats[3]);
		matList.Add (mats[4]);

		//This for loop randomly picks what the correct sequence of colors will be for this game.
		//It also applies the correct color material to the correct InstructionShape gameobject
		for (int i = 0; i < 5; i++) {
			//This randomly picks the next color to add to the sequence from the list of possible
			//		colors remaining that have not shown up in the sequence yet.
			pickRandomColorIndex = Random.Range (0, 5 - i);
			correctButtonOrder[i] = buttonChoices [pickRandomColorIndex];
			//After you choose a color to add, remove it from the list so that it doesn't get added twice.
			buttonChoices.RemoveAt (pickRandomColorIndex);
			//Apply the material to the InstructionShape gameobject
			instructionShapes[i].GetComponent<Renderer>().material = matList [pickRandomColorIndex];
			matList.RemoveAt (pickRandomColorIndex);
		}

		currentRound = -1;//This will be incremented to 0 at the beginning of the first round
		maxRound = 4;
		//Tell the Round Handler the correct button order
		roundHandler.GetComponent<RoundHandler> ().correctButtonOrder = correctButtonOrder;
		//Start the first round
		roundHandler.GetComponent<RoundHandler> ().StartRound (false);
	}
	
	// Update is called once per frame
	void Update () {

	}

	//This function takes care of what should happen at the beginning of each round for the
	//		InstructionShapes gameobjects
	//"restartingTheRound" is true if the player has to redo a round because of failure
	//		and false if the player is starting a new round for the first time. 
	public void StartRound(bool restartingTheRound){
		//If this is a new round, increment currentRound
		if (!restartingTheRound) {
			currentRound++;
			if (currentRound > maxRound) {
				print ("END GAME");
			}
		}
		//SetActive displays a gameobject in the scene and lets the player use it.
		//This loop sets the correct number of InstructionShapes as active for the current round.
		//For example 3 InstructionShapes will be active during round 3.
		for (int i = 0; i <= maxRound; i++) {
			if (i <= currentRound) {
				instructionShapes [i].SetActive (true);
			} else {
				instructionShapes [i].SetActive (false);
			}
		}
		//This code correctly sets the handColliders as not active during the phase of the game
		//when the instructions are displayed to the player.
		Vector3 myVec = handColliderR.transform.position;
		myVec.y = 0;
		handColliderR.transform.position = myVec;
		handColliderR.SetActive (false);
		myVec = handColliderL.transform.position;
		myVec.y = 0;
		handColliderL.transform.position = myVec;
		handColliderL.SetActive (false);

		//Tells the Buttons to go back to being displayed in their original unpressed form.
		buttons[0].GetComponent<ElevatorButton> ().ResetThisButton ();
		buttons[1].GetComponent<ElevatorButton> ().ResetThisButton ();
		buttons[2].GetComponent<ElevatorButton> ().ResetThisButton ();
		buttons[3].GetComponent<ElevatorButton> ().ResetThisButton ();
		buttons[4].GetComponent<ElevatorButton> ().ResetThisButton ();
		//Invoke calls a function (first argument) after the specified amount of time (second argument)
		//TurnOffInstructions is called 5 seconds from now so that the correct color sequence (aka the 
		//		"instructions") can be displayed to the player for 5 seconds before it disappears.
		Invoke ("TurnOffInstructions", 5f);
	}

	//This function turns off the instructions and turns on the handColliders so that the player
	//		can start pressing buttons
	void TurnOffInstructions(){
		//Turn off all instructions
		for(int i = 0; i < 5; i++){
			instructionShapes[i].SetActive(false);
		}
		//Turn on handColliders
		handColliderR.SetActive (true);
		handColliderL.SetActive (true);
	}
}
