using UnityEngine;
using System.Collections;
using System;

public class CatapultAmmo2 : CatapultAmmo {

	public override int getTexIndex(){
		return 1;
	}
	public override int getLevel(){
		return 1;
	}

	public override int getDamage(){ return 20;}
}
