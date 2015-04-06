using UnityEngine;
using System.Collections;

public class gameStart : MonoBehaviour {

	public GameObject profile;
	private GameObject temp;
	// Use this for initialization
	void Start () {
		if (GameObject.Find(profile.name) == null)
		{
			temp = GameObject.Instantiate(profile);
			temp.name = profile.name;

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
