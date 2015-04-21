using UnityEngine;
using System.Collections;

public class FruitSpawner : MonoBehaviour {
	public GameObject fruitObject;
	public float timer, spawnRate;
	public float fruitSpeed;
	public GameObject profile;

	// Use this for initialization
	void Start () {
		timer = Time.time;
		spawnRate = 1f;
		profile = GameObject.Find("User_Profile");
		if(profile.GetComponent<userProfile>().fruitHard){
			fruitSpeed = 0.1f;
		}
		else{
			fruitSpeed = 0.05f;
		}

	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - timer > spawnRate) {
			Vector3 pos = transform.position;
			pos.x += Random.Range(-8f, 8f);
			GameObject f = (GameObject) Instantiate (fruitObject, pos, transform.rotation);
			f.GetComponent<Fruit>().speed = fruitSpeed;
			timer = Time.time;
		}
	}
}
