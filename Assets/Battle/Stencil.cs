using UnityEngine;
using System.Collections;

public class Stancil {

	public int hp;
	public float speed;
	public Sprite sprite;
	public int buildStep;
	public int buildTime;
	public float damage;
	//public Blueprint blueprint;

	public Stancil(Blueprint blueprint){
		this.hp = blueprint.armor.getHp ();
		this.speed = blueprint.getSpeed();
		this.damage = blueprint.getDamage ();
	}
	
	public Unit createUnit(){
		Unit unit = new Unit ();
		return unit;
	}
}
