using UnityEngine;
using System.Collections;

public class Ram : Weapon {

	public Ram(){
		possibleAmmo = new RamAmmo[3];
		possibleAmmo [0] = new RamAmmo1 ();
		possibleAmmo [1] = new RamAmmo2 ();
		possibleAmmo [2] = new RamAmmo3 ();
		selectAmmo (0);
	}

	public override int getBaseSpeed() { return 4; }
	public override int getBaseTime(){ return 3; }
	public override int getRange(){ return 1; }
	public override int getLoadTime(){ return 2; }

	public override Projectile attack(Unit target, Unit origin){
		target.makeDamage (activeAmmo.getDamage());
		return null;
	}
}
