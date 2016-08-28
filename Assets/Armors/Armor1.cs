using UnityEngine;
using System.Collections;
using System;

public class Armor1 : Armor {
	public override int getTexIndex(){
		return 0;
	}

	public override int getLevel(){
		return 0;
	}

	public override int getHp(){ return 10; }
}
