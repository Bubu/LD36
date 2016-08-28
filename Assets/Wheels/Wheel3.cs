using UnityEngine;
using System.Collections;

public class Wheel3 : Wheel {

	public override int getTexIndex(){
		return 2;
	}
	public override int getLevel(){
		return 2;
	}
	public override float getBaseSpeed(){
		return 3f;
	}
}
