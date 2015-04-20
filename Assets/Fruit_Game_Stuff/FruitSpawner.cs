using UnityEngine;
using System.Collections;

public class FruitSpawner : MonoBehaviour {
	public GameObject fruitObject;
	public float timer, spawnRate;

	// Use this for initialization
	void Start () {
		timer = Time.time;
		spawnRate = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - timer > spawnRate) {
			Vector3 pos = transform.position;
			pos.x += Random.Range(-8f, 8f);
			Instantiate (fruitObject, pos, transform.rotation);
			timer = Time.time;
		}
	}
}
