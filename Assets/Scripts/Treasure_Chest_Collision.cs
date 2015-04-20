using UnityEngine;
using System.Collections;

public class Treasure_Chest_Collision : MonoBehaviour {

	public bool treasure_found;
	public int counter;
	public bool isBeginning;

	// Use this for initialization
	void Start () {
		treasure_found = false;
		counter = 0;
		isBeginning = true;
	}
	
	// Update is called once per frame
	void Update () {
		if ((counter == 0) && !isBeginning && !treasure_found) {
			
			print ("Shiver me timbers! You found the treasure!");
			
			treasure_found = true;
		}
	}

	void OnTriggerEnter(Collider coll)
	{
		++counter;

		isBeginning = false;

		if (coll.gameObject.tag == "Coin_Copy" && !treasure_found)
		{
			Rigidbody rigid_body = GetComponent<Rigidbody>();
		}
	}

	void OnTriggerExit(Collider coll)
	{
		--counter;
	}
}
