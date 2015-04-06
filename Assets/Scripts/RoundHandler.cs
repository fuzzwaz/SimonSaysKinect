using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RoundHandler : MonoBehaviour {

	//The Round Handler is attached to the Game Manager.
	//It keeps track of the correct sequence of buttons to be pressed 
	//		for each round. 

	int currentRound;
	public InstructionHandler instructionHandler;
	//This array holds the correct overall sequence of 5 colors that will be used during
	// 		 the whole game. The Instruction Handler will set these values.
	public string[] correctButtonOrder = new string[5];
	//This Queue holds the correct sequence of colors for the current round.
	//The top of the queue will always be the next button that the player needs to press.
	//An empty queue means that the player has pressed every button for that round, and 
	//		that the next round will begin. 
	public Queue<string> currentRoundCorrectButtonOrder = new Queue<string>();

	// Use this for initialization
	void Start () {
		currentRound = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//This function sets the queue to its correct form at the beginning of each round
	//"restartingTheRound" is true if the player has to redo a round because of failure
	//		and false if the player is starting a new round for the first time. 
	public void StartRound(bool restartingTheRound){
		//if you are restarting a round, clear the queue
		if (restartingTheRound) {
			currentRoundCorrectButtonOrder.Clear();
		}
		//if you are starting a new round, increase the currentRound and make sure the queue is clear.
		else {
			currentRound++;
			if (currentRoundCorrectButtonOrder.Count != 0) {
				print ("error");
			}
		}
		//Add the correct sequence of buttons for this round to the queue
		for (int i = 0; i < currentRound; i++) {
			currentRoundCorrectButtonOrder.Enqueue (correctButtonOrder [i]);
		}
		//Tell the Instruction Handler to do what it should at the start of a round
		instructionHandler.GetComponent<InstructionHandler> ().StartRound (restartingTheRound);
	}
}
