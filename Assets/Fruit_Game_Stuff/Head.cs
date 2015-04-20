using UnityEngine;
using System.Collections;

public class Head : MonoBehaviour {
	float speed;

	// Use this for initialization
	void Start () {
		speed = 0.3f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)) {
			Vector3 temp = transform.position;  
			temp.x -= speed;
			transform.position = temp;
		}
		else if (Input.GetKey(KeyCode.D)){
			Vector3 temp = transform.position;  
			temp.x += speed;
			transform.position = temp;
		}
	}
}
