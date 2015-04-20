using UnityEngine;
using System.Collections;

public class Treasure_Chest_Spawner : MonoBehaviour {

	//GameObject treasure_chest = GameObject.FindGameObjectWithTag("Treasure_Chest");

	//public Vector3 starting_location = treasure_chest.transform;

	public int number_of_treasure_chests;

	public GameObject treasure_chest_object;

	public GameObject[] spawned_treasure_chests;

	// Use this for initialization
	void Start () {
		spawned_treasure_chests = new GameObject[number_of_treasure_chests];
		Invoke ("Spawn_Multiple_Treasure_Chests", 0.5f);
		// Randomize the position of the treasure chest when the game first starts
		//transform.position = new Vector3(Random.Range (-9, 9), Random.Range (-5, 5), 1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		string printString = "";
		for (int i = 0; i < number_of_treasure_chests; ++i)
		{
			printString = printString + i.ToString() + ": " + spawned_treasure_chests[i].GetComponent<Treasure_Chest_Collision>().counter.ToString() + ", ";
		}
		print (printString);
		for (int i = 0; i < number_of_treasure_chests; ++i)
		{
			if (!spawned_treasure_chests[i].GetComponent<Treasure_Chest_Collision>().treasure_found)
			{
				return;
			}
		}

		print ("Shiver me timbers! You found the treasure!");
	}

	void Spawn_Multiple_Treasure_Chests()
	{
		for (int i = 0; i < number_of_treasure_chests; ++i)
		{
			spawned_treasure_chests[i] = (GameObject) Instantiate (treasure_chest_object, new Vector3(Random.Range (-9, 9), Random.Range (-5, 5), 1.5f), Quaternion.identity);
		}
	}
}
