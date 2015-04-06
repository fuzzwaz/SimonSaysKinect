using UnityEngine;
using System.Collections;

public class turnOff : MonoBehaviour {

	public GameObject enab;
	public GameObject disab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnClick() {
		enab.SetActive(false);
		disab.SetActive(true);
		
		
	}
}
