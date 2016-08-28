using UnityEngine;
using System.Collections;

public class RamAmmo3 : RamAmmo {

	public override int getTexIndex(){
		return 8;
	}
	public override int getLevel(){
		return 2;
	}

	public override int getDamage(){ return 3;}
}
