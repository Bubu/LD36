using UnityEngine;
using System.Collections;

public class Catapult : Weapon {

	public new CatapultAmmo ammo;

	public override float getSpeed (Wheel wheel) {
		return 4.4f;
	}
}
