using UnityEngine;
using System.Collections;

public class Fruit : MonoBehaviour {
	float speed, timer;
	// Use this for initialization
	void Start () {
		speed = 0.1f;
		timer = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = transform.position;
		temp.y -= speed;
		transform.position = temp;

		if (Time.time - timer > 10f) {
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter(Collision collision){
		Destroy (gameObject);
	}
}
