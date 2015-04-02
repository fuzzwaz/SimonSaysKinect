using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public Rigidbody knight;
	public int direction;
	public Vector3 dirVector;
	enum directionEnum{up, down, left, right};

	// Use this for initialization
	void Start () {
		Vector3[] dirVectors = new Vector3[4];
		float forceVelocity = Random.Range (25, 75);
		dirVectors [(int)directionEnum.up] = new Vector3 (0, forceVelocity, 0);
		dirVectors [(int)directionEnum.down] = new Vector3 (0, -forceVelocity, 0);
		dirVectors [(int)directionEnum.left] = new Vector3 (-forceVelocity, 0, 0);
		dirVectors [(int)directionEnum.right] = new Vector3 (forceVelocity, 0, 0);
		dirVector = dirVectors [direction];
		InvokeRepeating ("LaunchKnight", Random.Range (1, 3), Random.Range (3, 5));
	}
	
	// Update is called once per frame
	void Update () {

	}

	void LaunchKnight () {
		Rigidbody startKnight = (Rigidbody) Instantiate (knight, transform.position, Quaternion.identity);
		startKnight.GetComponent<Knight> ().force = dirVector;
		Destroy (startKnight.gameObject, 50);
	}
}
