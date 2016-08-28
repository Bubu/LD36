using UnityEngine;
using System.Collections;

public abstract class Weapon {

	public Ammo[] possibleAmmo;
	public Ammo activeAmmo;

	public void selectAmmo(int ammoIndex){
		activeAmmo = possibleAmmo[ammoIndex];
	}

	public abstract float getSpeed (Wheel wheel);

}
