using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class DesignScript : MonoBehaviour {

	public Blueprint[] warplan;
	public Blueprint activeBlueprint;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this);
		warplan = new Blueprint[3];
		for (int i=0; i<3; i++){
			warplan[i] = new Blueprint();
		}
		activeBlueprint = warplan [0];
		Debug.Log ("huhu!");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
