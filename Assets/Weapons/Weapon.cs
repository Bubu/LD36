using UnityEngine;
using System.Collections;

public abstract class Weapon {

	public Ammo[] possibleAmmo;
	public Ammo activeAmmo;

	public void selectAmmo(int ammoIndex){
		activeAmmo = possibleAmmo[ammoIndex];
	}
	public abstract int getBaseSpeed ();
	public abstract int getBaseTime ();
	public abstract int getRange ();
	public abstract int getLoadTime ();
	public abstract Projectile attack (Unit target, Unit origin);
}
