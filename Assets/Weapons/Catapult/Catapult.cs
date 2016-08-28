using UnityEngine;
using System.Collections;

public class Catapult : Weapon {

	public new CatapultAmmo activeAmmo;

	public Catapult(){
		possibleAmmo = new CatapultAmmo[3];
		possibleAmmo [0] = new CatapultAmmo1 ();
		possibleAmmo [1] = new CatapultAmmo2 ();
		possibleAmmo [2] = new CatapultAmmo3 ();
		selectAmmo (0);
	}

	public override float getBaseSpeed () { return 2f; }

	public override float getBaseTime(){ return 6f; }
}
