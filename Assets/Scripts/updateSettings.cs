using UnityEngine;
using System.Collections;

public class updateSettings : MonoBehaviour {

	public GameObject leftHand_Enabled;
	public GameObject rightHand_Enabled;
	public GameObject head_Enabled;

	public GameObject leftHand_Disabled;
	public GameObject rightHand_Disabled;
	public GameObject head_Disabled;

	public GameObject profile;
	// Use this for initialization
	void Start () {
		profile = GameObject.Find("User_Profile");
		if (profile != null)
		{
			if (profile.GetComponent<userProfile>().left_hand != true)
			{
				leftHand_Enabled.SetActive(false);
				leftHand_Disabled.SetActive(true);
			}

			if (profile.GetComponent<userProfile>().right_hand != true)
			{
				rightHand_Enabled.SetActive(false);
				rightHand_Disabled.SetActive(true);
			}

			if (profile.GetComponent<userProfile>().head != true)
			{
				head_Enabled.SetActive(false);
				head_Disabled.SetActive(true);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (profile != null)
		{
			if (leftHand_Enabled.activeSelf == true)
			{profile.GetComponent<userProfile>().left_hand = true;}
			else
			{profile.GetComponent<userProfile>().left_hand = false;}

			if (rightHand_Enabled.activeSelf == true)
			{profile.GetComponent<userProfile>().right_hand = true;}
			else
			{profile.GetComponent<userProfile>().right_hand = false;}

			if (head_Enabled.activeSelf == true)
			{profile.GetComponent<userProfile>().head = true;}
			else
			{profile.GetComponent<userProfile>().head = false;}
		}
	
	}
}
