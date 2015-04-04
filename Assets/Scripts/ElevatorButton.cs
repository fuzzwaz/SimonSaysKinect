using UnityEngine;
using System.Collections;

public class ElevatorButton : MonoBehaviour {

	public bool pushed;
	public string color;
	public string shape;
	public Material originalMat;
	public Material pushedMat;

	// Use this for initialization
	void Start () {
		pushed = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void NextRound(){
		pushed = false;
		renderer.material = originalMat;
	}

	void OnTriggerEnter (Collider collider) {
		//if (collider.gameObject.tag == "Hand") {
			pushed = true;
			renderer.material = pushedMat;
		//}
	}
}
