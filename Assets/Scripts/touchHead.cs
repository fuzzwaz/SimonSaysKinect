using UnityEngine;
using System.Collections;

public class touchHead : MonoBehaviour {

	public GameObject carlMan;
	public GameObject pointSystem;
	private Transform headPosition;
	private Transform rightHandPosition;
	private Transform leftHandPosition;
	public GameObject commandManager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		rightHandPosition = carlMan.GetComponent<ZigSkeleton> ().LeftWrist;
//		leftHandPosition = carlMan.GetComponent<ZigSkeleton> ().RightWrist;
//		headPosition = carlMan.GetComponent<ZigSkeleton> ().Head;
////		print (Vector3.Distance(rightHandPosition.position,headPosition.position));
//
//
//		if (commandManager.GetComponent<commandManager> ().playerLabel == "TouchYourHeadR") {
//			if (Vector3.Distance (rightHandPosition.position, headPosition.position) <= 0.3f && commandManager.GetComponent<commandManager> ().playing) {
//				pointSystem.GetComponent<gameManager> ().CorrectPlayerInput ();
//			}
//		} 
//		else if (commandManager.GetComponent<commandManager> ().playerLabel == "TouchYourHeadL") 
//		{
//			if (Vector3.Distance (leftHandPosition.position, headPosition.position) <= 0.3f && commandManager.GetComponent<commandManager> ().playing) {
//				pointSystem.GetComponent<gameManager> ().CorrectPlayerInput ();
//			}
//		}
	}
}
