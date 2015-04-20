using UnityEngine;
using System.Collections;

public class Coin_Spawner : MonoBehaviour {
	
	public int number_of_coins;
	public GameObject coin_object;

	// Use this for initialization
	void Start () {
		Spawn_Multiple_Coins();
	}

	void Spawn_Multiple_Coins()
	{
		//transform.position = new Vector3(Random.Range (-9, 9), Random.Range (-5, 5), 0);

		for (int i = 0; i < number_of_coins; ++i)
		{
			Instantiate(coin_object, new Vector3(Random.Range(-14, 14), Random.Range(-10, 10), 1), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
