using UnityEngine;
using System.Collections;

public class Coin_Collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision coll)
	{
		if (coll.gameObject.tag == "Right_Hand" || coll.gameObject.tag == "Left_Hand")
		{
			Rigidbody rigid_body = GetComponent<Rigidbody>();

			rigid_body.AddForce(coll.contacts[0].normal * 100.0f * Time.deltaTime, ForceMode.Impulse);

			GetComponent<AudioSource>().Play();
		}
	}
}
