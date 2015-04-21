using UnityEngine;
using System.Collections;

public class PaddleLeftScript : MonoBehaviour {

	float paddleSpeed = 10f;
	public GameObject BallPreFab;
	Rigidbody ballRigidbody;
	
	public GameObject carlMan;
	public GameObject userProfile;
	public gameManager pointManager;

	int lives = 4;
	int lastLevel = 1;
	float speed;
	GUIText guiLives;
	GUIText guiScore;

	int score = 0;

	GameObject newBall = null;

	// Use this for initialization
	void Start () {
		//DontDestroyOnLoad(GameObject.Find("guiScore"));
		//DontDestroyOnLoad(GameObject.Find("guiLives"));
		guiLives = GameObject.Find ("guiLives").GetComponent<GUIText> ();
		guiScore = GameObject.Find ("guiScore").GetComponent<GUIText> ();
		speed = 9;
		//hard - 13
		SpawnBall ();
		gameObject.SetActive (true);
	}

	public void AddPoint(int v){
		score += v;
		guiScore.text = "Score: " + score;
	}

	public void SpawnBall () {
		newBall = (GameObject)Instantiate (BallPreFab);
		lives--;
		guiLives.text = "Lives: " + lives;
		if (lives == 0) {
			Destroy(gameObject);
			pointManager.GetComponent<gameManager>().EndPongGame();
		}
	}

	// Update is called once per frame
	void Update () {

		Vector3 myVec = transform.position;
		myVec.y = carlMan.GetComponent<ZigSkeleton> ().RightWrist.position.y;
		myVec.y = myVec.y - 1.5f;
		myVec.y = myVec.y*30f;
		transform.position = myVec;
//		transform.Translate (paddleSpeed * Time.deltaTime * Input.GetAxis ("LeftBar"), 0, 0);
//		if (transform.position.y > 7.4f) {
//			transform.position = new Vector3(transform.position.x, 7.4f, transform.position.z);
//		}
//		if (transform.position.y < -7.39f) {
//			transform.position = new Vector3(transform.position.x, -7.39f, transform.position.z);
//		}
		if (newBall) {
			ballRigidbody = newBall.GetComponent<Rigidbody> ();
			//ballRigidbody.AddForce (300f, -150f, 0);
			ballRigidbody.velocity = new Vector3 (10f, 10f, 0);
			newBall = null;
		} else {
			Vector3 balltempvelocity = ballRigidbody.velocity;
			balltempvelocity.Normalize();
			ballRigidbody.velocity = balltempvelocity * speed;
		}
	}
}