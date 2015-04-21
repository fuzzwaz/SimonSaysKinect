using UnityEngine;
using System.Collections;

public class fiveswap : MonoBehaviour {

	private float timer = 5.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.activeSelf) {
			timer -= Time.deltaTime;
			if (timer < 0.0f)
			{
				timer = 5.0f;
				this.gameObject.SetActive(false);
			}
		}
	}
}
