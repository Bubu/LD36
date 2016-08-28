using UnityEngine;
using System.Collections;

public class BallistaAmmo3 : BallistaAmmo {

	public override int getTexIndex(){
		return 5;
	}
	public override int getLevel(){
		return 2;
	}
	public override int getDamage(){ return 30;}
}
