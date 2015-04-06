using UnityEngine;
using System.Collections;

public class ElevatorButton : MonoBehaviour {

	public bool pushed;
	public string color;
	public string shape;
	public Material originalMat;
	public Material pushedMat;
	public RoundHandler roundHandler;

	// Use this for initialization
	void Start () {
		pushed = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void NextRound(){
		pushed = false;
		GetComponent<Renderer>().material = originalMat;
	}

	void OnTriggerEnter (Collider collider) {
		//if (collider.gameObject.tag == "Hand") {
			pushed = true;
			GetComponent<Renderer>().material = pushedMat;
			string nextButton = roundHandler.GetComponent<RoundHandler>().currentRoundQueue.Dequeue();
			if (nextButton == color) {
				print ("correct!");
				if(roundHandler.GetComponent<RoundHandler>().currentRoundQueue.Count == 0){
					roundHandler.GetComponent<RoundHandler>().NextRound();
				}
			} else {
				print ("wrong!!!");
			}
		//}
	}

	void OnCollisionEnter (Collision col){
		print ("Hello");
	}
}
