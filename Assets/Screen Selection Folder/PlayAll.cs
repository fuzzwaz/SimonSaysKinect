using UnityEngine;
using System.Collections;

public class PlayAll : MonoBehaviour {
	
	public GameObject profile;

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
			profile.GetComponent<userProfile>().playAll = true;
			if(profile.GetComponent<userProfile>().left_hand || profile.GetComponent<userProfile>().right_hand){
				Application.LoadLevel ("MainLevel_FlyingKnights");
			}
			else if(profile.GetComponent<userProfile>().head){
				Application.LoadLevel ("MainLevel_Fruits");
			}
		}
	}
}
