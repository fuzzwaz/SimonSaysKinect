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
		if ((counter == 0) && !isBeginning && !treasure_found)
		{
			treasure_found = true;
			print ("done");
		}
	}

	void OnTriggerEnter(Collider coll) {

		if (coll.gameObject.tag == "Coin" && !treasure_found)
		{
			++counter;
			isBeginning = false;
		}
	}

	void OnTriggerExit(Collider coll){
		
		if (coll.gameObject.tag == "Coin" && !treasure_found)
		{
			--counter;
		}
	}
}

