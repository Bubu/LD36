using UnityEngine;
using System.Collections;

public class Catapult : Weapon {

	public Catapult(){
		possibleAmmo = new CatapultAmmo[3];
		possibleAmmo [0] = new CatapultAmmo1 ();
		possibleAmmo [1] = new CatapultAmmo2 ();
		possibleAmmo [2] = new CatapultAmmo3 ();
		selectAmmo (0);
	}

	public override int getBaseSpeed () { return 2; }
	public override int getBaseTime(){ return 6; }
	public override int getRange(){ return 10; }
	public override int getLoadTime(){ return 10; }
	public override Projectile attack(Unit target, Unit origin){
		return new BallistaProjectile(origin, activeAmmo.getDamage(), GameResources.Instance.projectileTexList [activeAmmo.getTexIndex()]);
	}
}
