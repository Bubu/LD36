using UnityEngine;
using System.Collections;
using System;

public class CatapultAmmo3 : CatapultAmmo {

	public override int getTexIndex(){
		return 2;
	}
	public override int getLevel(){
		return 2;
	}

	public override int getDamage(){ return 30;}
}
