using UnityEngine;
using System.Collections;

public class HandColliderElevator : MonoBehaviour {
	
	public GameObject carlMan;
	//is this collider for the right or left hand? "R" for right, "L" for left
	public string rightLeft;

	// Use this for initialization
	void Start () {
		//The handColliders are not active at the beginning of Elevator/Simon game.
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		//Sets the handColliders to a position on screen that makes playing the game easier.
		if (rightLeft == "R") {
			Vector3 myVec = carlMan.GetComponent<ZigSkeleton> ().LeftWrist.position;
			myVec.x = myVec.x + 0.8f;
			myVec.x = myVec.x*9f;
			myVec.y = myVec.y*4f;
			myVec.z = 0;
			transform.position = myVec;
		} else if (rightLeft == "L") {
			Vector3 myVec = carlMan.GetComponent<ZigSkeleton> ().RightWrist.position;
			myVec.x = myVec.x + 0.8f;
			myVec.x = myVec.x*8f;
			myVec.y = myVec.y*4f;
			myVec.z = 0;
			transform.position = myVec;
		}
	}
}
