using UnityEngine;
using System.Collections;

public class userProfile : MonoBehaviour {

	public int totalPoints = 0;

	public bool left_hand = true;
	public bool right_hand = true;
	public bool head = true;
	public bool torso = true;
	// Use this for initialization
	void Start () {

		Object.DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
