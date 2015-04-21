using UnityEngine;
using System.Collections;

public class BrickScript : MonoBehaviour {

	static int numBricks = 0;
	public int pointValue = 1;
	public int hitPoints = 1;
	public GameObject userProfile;
	public gameManager pointManager;
	
	// Use this for initialization
	void Start () {
		numBricks++;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision col){
		hitPoints--;
		if (hitPoints <= 0) {
			Die ();
		}
	}

	void Die() {
		Destroy (gameObject);
		PaddleLeftScript paddleLeftScript = GameObject.Find ("PaddleLeft").GetComponent<PaddleLeftScript> ();
		paddleLeftScript.AddPoint (pointValue);
		GameObject[] bricks = GameObject.FindGameObjectsWithTag ("Brick");
		numBricks--;
		if (numBricks <= 0) {
			pointManager.GetComponent<gameManager>().EndPongGame();
		}
	}
}
