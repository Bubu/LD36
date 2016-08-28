using UnityEngine;
using System.Collections;
using System;

public class CatapultAmmo1 : CatapultAmmo {

	public override int getTexIndex(){
		return 0;
	}
	public override int getLevel(){
		return 0;
	}
	public override int getDamage(){ return 10;}

}
