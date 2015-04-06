using UnityEngine;
using System.Collections;

public class HandColliderKnights : MonoBehaviour {
	
	public GameObject carlMan;
	public string rightLeft;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (rightLeft == "R") {
			Vector3 myVec = carlMan.GetComponent<ZigSkeleton> ().RightWrist.position;
			myVec.z = -6.96f;
			transform.position = myVec;
		} else if (rightLeft == "L") {
			Vector3 myVec = carlMan.GetComponent<ZigSkeleton> ().LeftWrist.position;
			myVec.z = -6.96f;
			transform.position = myVec;
		}
	}

	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "Knight") {
			print ("Game Over");
		}
	}
}
