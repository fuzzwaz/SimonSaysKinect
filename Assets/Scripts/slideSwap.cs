using UnityEngine;
using System.Collections;

public class slideSwap : MonoBehaviour {
	public GameObject slide1;
	public GameObject slide2;
	
	private float startTimer = 0.0f;
	private float endTimer = 5.0f;
	// Use this for initialization
	void Start () {
		slide1.SetActive(true);
		slide2.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (startTimer > endTimer)
		{
			if (slide1.activeSelf == true)
			{
				slide1.SetActive(false);
				slide2.SetActive(true);
				startTimer = 0.0f;
				
			}
			else
			{
				slide2.SetActive(false);
				//start game
			}
		}
		startTimer += Time.deltaTime;
	}
}
