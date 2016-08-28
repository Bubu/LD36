using UnityEngine;
using System.Collections;

public class Armor3 : Armor {
	
	public override int getTexIndex(){
		return 2;
	}

	public override int getLevel(){
		return 2;
	}

	public override int getHp(){ return 30; }
}
