using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public Rigidbody knight;
	public int direction;
	public Vector3 dirVector;
	public gameManager pointManager;
	public Transform handTransform;
	public float forceVelocity;

	// Use this for initialization
	void Start () {
		Vector3[] dirVectors = new Vector3[4];
		forceVelocity = Random.Range (150, 300);
//		dirVectors [0] = new Vector3 (0, forceVelocity, 0);
//		dirVectors [1] = new Vector3 (0, -forceVelocity, 0);
//		dirVectors [2] = new Vector3 (-forceVelocity, 0, 0);
//		dirVectors [3] = new Vector3 (forceVelocity, 0, 0);
//		dirVector = dirVectors [direction];
		InvokeRepeating ("LaunchKnight", Random.Range (12, 14), Random.Range (3, 5));
	}
	
	// Update is called once per frame
	void Update () {

	}

	void LaunchKnight () {
		Vector3 launchPosition = transform.position;
		if (direction <= 1) {
			launchPosition.x = launchPosition.x + Random.Range (-9, 9);
		} else {
			launchPosition.y = launchPosition.y + Random.Range (-3.5f, 5.5f);
		}
		Rigidbody startKnight = (Rigidbody) Instantiate (knight, launchPosition, Quaternion.identity);
		Vector3 launchDirection = new Vector3 ();
		launchDirection = handTransform.position - launchPosition;
		startKnight.GetComponent<Knight> ().force = Vector3.Normalize(launchDirection) * forceVelocity;
		startKnight.GetComponent<Knight> ().pointManager = pointManager;
	}
}
