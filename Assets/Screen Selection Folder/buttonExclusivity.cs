using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttonExclusivity : MonoBehaviour {

	public Toggle easy;
	public Toggle hard;

	private bool hardloop = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (easy.isOn && !hardloop)
		{
			if (hard.isOn)
			{
				easy.isOn = false;
				hardloop = true;
			}
		}


		if (hard.isOn && hardloop)
		{
			if (easy.isOn)
			{
				hard.isOn = false;
				hardloop = false;
			}
		}

		if (hard.isOn == false && easy.isOn == false)
		{
			if (hardloop)
			{
				hard.isOn = true;
			}
			else
			{
				easy.isOn = true;
			}
		}
	
	}
}
