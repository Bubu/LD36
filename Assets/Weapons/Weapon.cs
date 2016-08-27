using UnityEngine;
using System.Collections;

public abstract class Weapon : Element {

	public Ammo ammo;

	// Use this for initialization
	void Start () {
	
	}

	public abstract float getSpeed (Wheel wheel);

}
