using UnityEngine;
using System.Collections;

public class PaddleRightScript : MonoBehaviour {

	float paddleSpeed = 10f;
	
	public GameObject carlMan;
	public GameObject userProfile;

	// Use this for initialization
	void Start () {
		gameObject.SetActive (true);
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 myVec = transform.position;
		myVec.y = carlMan.GetComponent<ZigSkeleton> ().LeftWrist.position.y;
		myVec.y = myVec.y - 1.5f;
		myVec.y = myVec.y*30f;
		transform.position = myVec;
//		transform.Translate (paddleSpeed * Time.deltaTime * Input.GetAxis ("RightBar"), 0, 0);
//		if (transform.position.y > 7.4f) {
//			transform.position = new Vector3(transform.position.x, 7.4f, transform.position.z);
//		}
//		if (transform.position.y < -7.39f) {
//			transform.position = new Vector3(transform.position.x, -7.39f, transform.position.z);
//		}
	}

	/*void OnCollisionEnter(Collision col){
		foreach(ContactPoint contact in col.contacts) {
			if(contact.thisCollider == gameObject.GetComponent<Collider>()) {
				//this is the paddle's contact point
				float english = contact.point.y - transform.position.y;

				contact.otherCollider.GetComponent<Rigidbody>().AddForce(0, 125f * english, 0);
			}
		}
	}*/
}