using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class on_off : MonoBehaviour {

	public GameObject enab;
	public GameObject disab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick() {
		enab.SetActive(true);
		disab.SetActive(false);


	}
}
