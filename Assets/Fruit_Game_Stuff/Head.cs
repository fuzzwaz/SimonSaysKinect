using UnityEngine;
using System.Collections;

public class Head : MonoBehaviour {
	float speed;
	public Transform headLoc;
	public GameObject userProfile;

	// Use this for initialization
	void Start () {
		speed = 0.3f;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 myVec = transform.position;
		myVec.x = headLoc.position.x*38 + 43;
		transform.position = myVec;

//		if (Input.GetKey(KeyCode.A)) {
//			Vector3 temp = transform.position;  
//			temp.x -= speed;
//			transform.position = temp;
//		}
//		else if (Input.GetKey(KeyCode.D)){
//			Vector3 temp = transform.position;  
//			temp.x += speed;
//			transform.position = temp;
//		}
	}
}
