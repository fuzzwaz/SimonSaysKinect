using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RoundHandler : MonoBehaviour {

	int currentRound;
	int maxRound;
	public InstructionHandler instructionHandler;
	public string[] correctButtonOrder = new string[5];
	public Queue<string> currentRoundQueue;

	// Use this for initialization
	void Start () {
		currentRoundQueue.Enqueue (correctButtonOrder [1]);
		currentRound = 1;
		maxRound = 5;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void NextRound(){
		currentRound++;
		if (currentRoundQueue.Count != 0) {
			print ("error");
		}
		for (int i = 0; i < currentRound; i++) {
			currentRoundQueue.Enqueue (correctButtonOrder [i]);
		}
		instructionHandler.GetComponent<InstructionHandler> ().NextRound ();
	}
}
