using System;
using UnityEngine;
using System.Collections.Generic;

public class Unit
{
	public int position;
	public bool dead;
	public Stencil stencil;
	public int curHp;
	private int loadStep;
	public GameObject gameObject;
	Camera camera;

	public Unit (Stencil stencil, Camera camera)
	{
		this.stencil = stencil;
		this.curHp = stencil.hp;
		this.loadStep = 0;

		gameObject = new GameObject ();
		gameObject.name = "A Weapon";
		var sr = gameObject.AddComponent<SpriteRenderer>();

		this.camera = camera;
		if (stencil.player.isLeftPlayer) {
			sr.flipX = true;
		}
		sr.sprite = stencil.sprite;
		position = stencil.player.homePosition;
		gameObject.transform.position = getScreenPosition();
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
			if (otherUnit.stencil.player != stencil.player) {
				if (Math.Abs (otherUnit.position - position) < stencil.range) {
					target = otherUnit;
				}
			}
		}
		return target;
	}

	public int checkDistance(){
		if (stencil.player.isLeftPlayer) {
			return stencil.battle.width - position;
		} else {
			return position;
		}
	}

	public void move(){
		if (stencil.player.isLeftPlayer) {
			position = position + (int)stencil.speed;
		} else {
			position = position - (int)stencil.speed;
		}
		gameObject.transform.position = getScreenPosition();
	}

	public void makeDamage(int damage){
		curHp -= damage;
		if (curHp <= 0) {
			dead = true;
		}
	}

	Vector3 getScreenPosition ()
	{
		float viewportWidth = camera.orthographicSize * camera.aspect * 2;
		float viewPortHeigth = camera.orthographicSize * 2;
		return new Vector3 ( (viewportWidth * 0.05f ) + viewportWidth * ((float)position / stencil.battle.width * 0.9f), viewPortHeigth * 0.1f, 0f);
	}
}
