using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InstructionHandler : MonoBehaviour {

	public RoundHandler roundHandler;
	public GameObject[] instructionShapes = new GameObject[5];
	public Material[] mats = new Material[5];
	public ElevatorButton[] buttons = new ElevatorButton[5];

	int currentRound;
	int maxRound;
	string[] correctButtonOrder;

	// Use this for initialization
	void Start () {
		int pickRandomColorIndex = -1;
		correctButtonOrder = new string[5];
		
		List<string> buttonChoices = new List<string>();
		buttonChoices.Add ("red");
		buttonChoices.Add ("green");
		buttonChoices.Add ("blue");
		buttonChoices.Add ("orange");
		buttonChoices.Add ("purple");
		List<Material> matList = new List<Material>();
		matList.Add (mats[0]);
		matList.Add (mats[1]);
		matList.Add (mats[2]);
		matList.Add (mats[3]);
		matList.Add (mats[4]);

		for (int i = 0; i < 5; i++) {

			pickRandomColorIndex = Random.Range (0, 5 - i);
			correctButtonOrder[i] = buttonChoices [pickRandomColorIndex];
			buttonChoices.RemoveAt (pickRandomColorIndex);
			instructionShapes[i].GetComponent<Renderer>().material = matList [pickRandomColorIndex];
			matList.RemoveAt (pickRandomColorIndex);
		}

		instructionShapes[0].SetActive (true);
		instructionShapes[1].SetActive (false);
		instructionShapes[2].SetActive (false);
		instructionShapes[3].SetActive (false);
		instructionShapes[4].SetActive (false);

		roundHandler.GetComponent<RoundHandler> ().correctButtonOrder = correctButtonOrder;
		currentRound = 1;
		maxRound = 5;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			NextRound ();
		}
	}

	public void NextRound(){
		currentRound++;
		if (currentRound == 2) {
			instructionShapes[1].SetActive (true);
		}
		else if (currentRound == 3) {
			instructionShapes[2].SetActive (true);
		}
		else if (currentRound == 4) {
			instructionShapes[3].SetActive (true);
		}
		else if (currentRound == 5) {
			instructionShapes[4].SetActive (true);
		}
		else if (currentRound > maxRound) {
			print ("END GAME");
		}
		buttons[0].GetComponent<ElevatorButton> ().NextRound ();
		buttons[1].GetComponent<ElevatorButton> ().NextRound ();
		buttons[2].GetComponent<ElevatorButton> ().NextRound ();
		buttons[3].GetComponent<ElevatorButton> ().NextRound ();
		buttons[4].GetComponent<ElevatorButton> ().NextRound ();
	}
}
