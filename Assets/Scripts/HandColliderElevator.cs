using UnityEngine;
using System.Collections;

public class HandColliderElevator : MonoBehaviour {
	
	public GameObject carlMan;
	//is this collider for the right or left hand? "R" for right, "L" for left
	public string rightLeft;
	public GameObject userProfile;
	bool noRightHand;
	bool noLeftHand;

	// Use this for initialization
	void Start () {
		noRightHand = false;
		noLeftHand = false;
		gameObject.SetActive (false);
		Invoke ("TurnOnHands", 10.2f);
		//The handColliders are not active at the beginning of Elevator/Simon game.
		//gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

		//Sets the handColliders to a position on screen that makes playing the game easier.
		if (rightLeft == "R") {
			Vector3 myVec = carlMan.GetComponent<ZigSkeleton> ().LeftWrist.position;
			myVec.x = myVec.x + 1f;
			myVec.y = myVec.y - 1f;
			if(noLeftHand) {
				myVec.x = myVec.x + 1f;
				myVec.x = myVec.x*32f;
			}else {
				myVec.x = myVec.x*12f;
			}
			myVec.y = myVec.y*12f;
			myVec.z = 0;
			transform.position = myVec;
		} else if (rightLeft == "L") {
			Vector3 myVec = carlMan.GetComponent<ZigSkeleton> ().RightWrist.position;
			myVec.x = myVec.x + 1f;
			myVec.y = myVec.y - 1f;
			if(noRightHand) {
				myVec.x = myVec.x - 2f;
				myVec.x = myVec.x*32f;
			}else {
				myVec.x = myVec.x*12f;
			}
			myVec.y = myVec.y*12f;
			myVec.z = 0;
			transform.position = myVec;
		}
	}
	
	void TurnOnHands() {
		userProfile = GameObject.Find("User_Profile");
		if (rightLeft == "R") {
			if (userProfile.GetComponent<userProfile>().right_hand == true) {
				gameObject.SetActive (true);
			}else {
				noRightHand = true;
			}
		} else if (rightLeft == "L") {
			if (userProfile.GetComponent<userProfile>().left_hand == true) {
				gameObject.SetActive (true);
			}else{
				noLeftHand = true;
			}
		}
	}
}
