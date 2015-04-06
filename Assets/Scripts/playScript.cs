using UnityEngine;
using System.Collections;

public class playScript : MonoBehaviour {

	public string currentLevelName;

	// Use this for initialization
	void Start () {
		Invoke("EndKnightGame", 20f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick() {
		if (currentLevelName == "TitleScreen") {
			Application.LoadLevel ("MainLevel_FlyingKnights");
			currentLevelName = "MainLevel_FlyingKnights";
		}
	}

	void EndKnightGame() {
		if (currentLevelName == "MainLevel_FlyingKnights") {
			Application.LoadLevel ("MainLevel_Elevator");
			currentLevelName = "MainLevel_Elevator";
		}
	}

	public void EndElevatorGame() {
		if (currentLevelName == "MainLevel_Elevator") {
			Application.LoadLevel ("TitleScreen");
			currentLevelName = "TitleScreen";
		}
	}
}
