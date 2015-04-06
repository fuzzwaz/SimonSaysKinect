using UnityEngine;
using System.Collections;

public class HandColliderKnights : MonoBehaviour {
	
	public GameObject carlMan;
	public string rightLeft;
	public GameObject userProfile;

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
		Invoke ("TurnOnHands", 0.1f);
	}
	
	// Update is called once per frame
	void Update () {

		if (rightLeft == "R") {
			Vector3 myVec = carlMan.GetComponent<ZigSkeleton> ().LeftWrist.position;
			myVec.x = myVec.x + 0.8f;
			myVec.y = myVec.y - 0.85f;
			myVec.x = myVec.x*9f;
			myVec.y = myVec.y*9f;
			myVec.z = 0;
			transform.position = myVec;
		} else if (rightLeft == "L") {
			Vector3 myVec = carlMan.GetComponent<ZigSkeleton> ().RightWrist.position;
			myVec.x = myVec.x + 0.8f;
			myVec.y = myVec.y - 0.85f;
			myVec.x = myVec.x*9f;
			myVec.y = myVec.y*9f;
			myVec.z = 0;
			transform.position = myVec;
		}
	}
	
	void TurnOnHands() {
		userProfile = GameObject.Find("User_Profile");
		if (rightLeft == "R") {
			if (userProfile.GetComponent<userProfile>().right_hand == true) {
				gameObject.SetActive (true);
			}
		} else if (rightLeft == "L") {
			if (userProfile.GetComponent<userProfile>().left_hand == true) {
				gameObject.SetActive (true);
			}
		}
	}

	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "Knight") {
			print ("Game Over");
		}
	}
}
