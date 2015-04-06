using UnityEngine;
using System.Collections;

public class HandColliderElevator : MonoBehaviour {
	
	public GameObject carlMan;
	public string rightLeft;

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

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

//	void OnCollisionEnter (Collision collision) {
//		if (collision.gameObject.tag == "Button") {
//			string buttonColor = collision.gameObject.GetComponent<ElevatorButton> ().color;
//			if (buttonColor == "red"){
//
//			}
//		}
//	}
}
