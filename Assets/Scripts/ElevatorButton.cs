using UnityEngine;
using System.Collections;

public class ElevatorButton : MonoBehaviour {

	//This script takes care of the interactions of the buttons that the player will be 
	//		pressing in this game.

	public bool pushed;
	public string color;
	public string shape;
	public Material originalMaterial;
	public Material pushedMaterial;
	public RoundHandler roundHandler;

	// Use this for initialization
	void Start () {
		pushed = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	//Sets the button to being unpressed
	//This is done by changing the buttons material back to it's original solid color material
	public void ResetThisButton(){
		pushed = false;
		GetComponent<Renderer>().material = originalMaterial;
	}

	//This function handles what happens when the player presses a button
	void OnTriggerEnter (Collider collider) {
		//This if statement makes sure a hand collider is the object that hit the button
		//Also !pushed makes sure that the button will do the following things only when it is
		//		pressed for the first time:
		if (collider.gameObject.tag == "Hand" && !pushed) {
			pushed = true;
			//set material to its "pushed material" 
			GetComponent<Renderer>().material = pushedMaterial;
			//Checks which button the player was supposed to press
			string nextButton = roundHandler.GetComponent<RoundHandler>().currentRoundCorrectButtonOrder.Dequeue();
			//if player pressed correct button:
			if (nextButton == color) {
				if(roundHandler.GetComponent<RoundHandler>().currentRoundCorrectButtonOrder.Count == 0){
					roundHandler.GetComponent<RoundHandler>().AddPoints();
					//if this was the last button that needed to be pressed then tell the Round Handler
					//		to start the next round.
					//passing "false" into StartRound() is indicating that this will be a new round 
					//		instead of restarting this current round again
					roundHandler.GetComponent<RoundHandler>().StartRound(false);
				}
			} 
			//if player pressed an incorrect button:
			else {
				//Tell the Round Handler to start this current round again
				roundHandler.GetComponent<RoundHandler>().StartRound(true);
			}
		}
	}
}
