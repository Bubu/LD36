using UnityEngine;
using System.Collections;

public class Stencil {

	public int hp;
	public float speed;
	public Sprite sprite;
	public int buildStep;
	public int buildTime;
	public float damage;
	//public Blueprint blueprint;

	public Stencil(Blueprint blueprint){
		this.hp = blueprint.armor.getHp ();
		this.speed = blueprint.getSpeed();
		this.damage = blueprint.getDamage ();
		this.buildTime = blueprint.getBuildTime ();

		this.buildStep = 0;

		//this.sprite 
	}

	public Unit step(){
		buildStep = (buildStep + 1)%buildTime;
		if (buildStep == 0) {
			return new Unit (this);
		} else {
			return null;
		}
			
	}
			
}
