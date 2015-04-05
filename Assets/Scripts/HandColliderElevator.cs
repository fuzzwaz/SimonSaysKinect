using UnityEngine;
using System.Collections;

public class HandColliderElevator : MonoBehaviour {
	
	public GameObject carlMan;
	public string rightLeft;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (rightLeft == "R") {
			transform.position = carlMan.GetComponent<ZigSkeleton> ().LeftWrist.position;
		} else if (rightLeft == "L") {
			transform.position = carlMan.GetComponent<ZigSkeleton> ().RightWrist.position;
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
