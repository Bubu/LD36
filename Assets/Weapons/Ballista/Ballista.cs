using UnityEngine;
using System.Collections;

public class Ballista : Weapon {

	public Ballista(){
		possibleAmmo = new BallistaAmmo[3];
		possibleAmmo [0] = new BallistaAmmo1 ();
		possibleAmmo [1] = new BallistaAmmo2 ();
		possibleAmmo [2] = new BallistaAmmo3 ();
		selectAmmo (0);
	}

	public override int getBaseTime(){ return 5; }
	public override int getBaseSpeed(){ return 5; }
	public override int getRange(){ return 5; }
	public override int getLoadTime(){ return 5; }

	public override Projectile attack(Unit target, Unit origin){
		return new BallistaProjectile(origin, activeAmmo.getDamage(), GameResources.Instance.projectileTexList [activeAmmo.getTexIndex()]);
	}
}
