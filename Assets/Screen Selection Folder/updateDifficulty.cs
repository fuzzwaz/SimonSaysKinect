using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class updateDifficulty : MonoBehaviour {

	public Toggle knightH;
	public Toggle simonH;
	public Toggle pongH;
	public Toggle fruitH;
	public Toggle treasureH;

	public GameObject profile;
	// Use this for initialization
	void Start () {
		profile = GameObject.Find("User_Profile");
		profile.GetComponent<userProfile>().knightHard = false;
		profile.GetComponent<userProfile>().simonHard = false;
		profile.GetComponent<userProfile>().pongHard = false;
		profile.GetComponent<userProfile>().fruitHard = false;
		profile.GetComponent<userProfile>().treasureHard = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (knightH.isOn)
		{
			profile.GetComponent<userProfile>().knightHard = true;
		}
		else
		{
			profile.GetComponent<userProfile>().knightHard = false;
		}

		if (simonH.isOn)
		{
			profile.GetComponent<userProfile>().simonHard = true;
		}
		else
		{
			profile.GetComponent<userProfile>().simonHard = false;
		}

		if (pongH.isOn)
		{
			profile.GetComponent<userProfile>().pongHard = true;
		}
		else
		{
			profile.GetComponent<userProfile>().pongHard = false;
		}

		if (fruitH.isOn)
		{
			profile.GetComponent<userProfile>().fruitHard = true;
		}
		else
		{
			profile.GetComponent<userProfile>().fruitHard = false;
		}

		if (treasureH.isOn)
		{
			profile.GetComponent<userProfile>().treasureHard = true;
		}
		else
		{
			profile.GetComponent<userProfile>().treasureHard = false;
		}
	}
}
