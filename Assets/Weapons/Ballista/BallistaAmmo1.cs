using UnityEngine;
using System.Collections;

public class BallistaAmmo1 : BallistaAmmo {

	public override int getTexIndex(){
		return 3;
	}
	public override int getLevel(){
		return 0;
	}
	public override int getDamage(){ return 10;}

}
