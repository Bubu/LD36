using UnityEngine;
using System.Collections;

public class Ballista : Weapon {

	public Ballista(){
		possibleAmmo = new BallistaAmmo[3];
		possibleAmmo [0] = new BallistaAmmo1 ();
		possibleAmmo [1] = new BallistaAmmo2 ();
		possibleAmmo [2] = new BallistaAmmo2 ();
		selectAmmo (0);
	}

	public override float getBaseTime(){ return 5f; }
	public override float getBaseSpeed(){ return 5f; }
}
