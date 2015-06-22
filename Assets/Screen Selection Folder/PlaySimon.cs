using UnityEngine;
using System.Collections;

public class PlaySimon : MonoBehaviour {
	
	GameObject profile;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick ()
	{
		profile = GameObject.Find("User_Profile");
		if (profile != null){
			profile.GetComponent<userProfile>().playAll = false;
			Application.LoadLevel ("MainLevel_Elevator");
		}
	}
}
