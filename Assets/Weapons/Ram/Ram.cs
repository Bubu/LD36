using UnityEngine;
using System.Collections;

public class Ram : Weapon {

	public Ram(){
		possibleAmmo = new RamAmmo[3];
		possibleAmmo [0] = new RamAmmo1 ();
		possibleAmmo [1] = new RamAmmo2 ();
		possibleAmmo [2] = new RamAmmo2 ();
		selectAmmo (0);
	}

	public override float getSpeed (Wheel wheel) {
		return 4.4f;
	}
}
