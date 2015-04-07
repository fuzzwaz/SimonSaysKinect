using UnityEngine;
using System.Collections;

public class Knight : MonoBehaviour {

	public Vector3 force;
	public gameManager pointManager;
	public bool hitByPlayer;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().AddForce (force);
		hitByPlayer = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "GameEdge") {
			if (!hitByPlayer) {
				pointManager.GetComponent<gameManager> ().gamePoints += 20;
			}
			Destroy(gameObject);
		}
	}
}
