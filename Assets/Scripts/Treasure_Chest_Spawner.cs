using UnityEngine;
using System.Collections;

public class Treasure_Chest_Spawner : MonoBehaviour {

	//GameObject treasure_chest = GameObject.FindGameObjectWithTag("Treasure_Chest");

	//public Vector3 starting_location = treasure_chest.transform;

	// Use this for initialization
	void Start () {
		// Randomize the position of the treasure chest when the game first starts
		transform.position = new Vector3(Random.Range (-9, 9), Random.Range (-5, 5), 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
