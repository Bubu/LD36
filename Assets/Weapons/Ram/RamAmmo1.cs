using UnityEngine;
using System.Collections;

public class RamAmmo1 : RamAmmo {

	public override int getTexIndex(){
		return 6;
	}
	public override int getLevel(){
		return 0;
	}

	public override int getDamage(){ return 1;}
}
