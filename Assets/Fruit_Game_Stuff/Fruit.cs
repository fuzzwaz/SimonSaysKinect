using UnityEngine;
using System.Collections;

public class Fruit : MonoBehaviour {
	public float speed;
	float timer;
	// Use this for initialization
	void Start () {
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
