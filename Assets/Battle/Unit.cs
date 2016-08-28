using System;
using UnityEngine;
using System.Collections.Generic;

public class Unit
{
	public int position;
	public bool target;
	public Player player;
	public Stencil stencil;
	public int curHp;
	private int loadStep;
	public GameObject gameObject;

	public Unit (Stencil stencil)
	{
		this.stencil = stencil;
		this.curHp = stencil.hp;
		this.loadStep = 0;

		gameObject = new GameObject ();
		gameObject.name = "A Weapon";
		position = stencil.player.homePosition;
		float x = (float)position*10;
		gameObject.transform.position = new Vector3 (x, 0, 0);
	}

	public Projectile step(){
		/*
		1. Check for enemies in Range
		1.1 No Enemies -> Move
		1.2. Enemies -> release Projectile
		 */
		Projectile projectile = null;

		if (loadStep != 0) {
			loadStep -= 1;
		} else {
			Unit target = checkForTarget ();
			if (target!=null) {
				projectile = stencil.blueprint.weapon.attack(target, this);
				this.loadStep = stencil.loadTime;
			} else {
				move ();
			}
		}
		return projectile;
	}

	public Unit checkForTarget(){
		Unit target = null;
		foreach (Unit otherUnit in stencil.battle.units) {
			if (otherUnit.player != player) {
				if (Math.Abs (otherUnit.position - position) < stencil.range) {
					target = otherUnit;
				}
			}
		}
		return target;
	}

	public int checkDistance(){
		return Math.Abs((Convert.ToInt32(target) * 1000) - position);
	}

	public void launchProjectile(Unit target){
		
	}

	public void move(){
		
	}

	public void makeDamage(int damage){
		curHp -= damage;
	}
}
