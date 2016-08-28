using UnityEngine;
using System.Collections;
using System;

public class BallistaProjectile : Projectile {

	public int position;
	public int curLivingTime;
	public int speed;
	public int damage;
	public bool dead;
	public Sprite sprite;
	
	// Update is called once per frame

	public BallistaProjectile (Unit origin, int damage, Texture2D tex)
	{
		this.origin = origin;
		this.damage = damage;
		this.dead = false;
		this.sprite = Sprite.Create(tex,new Rect(0,0,tex.width,tex.height),new Vector2(0,0),tex.width);
	}

	void step () {

		Unit target = checkForTarget ();
		if (target != null) {
			target.makeDamage (damage);
			dead = true;
		} else {
			move ();
		}

	}

	public Unit checkForTarget(){
		Unit target = null;
		foreach (Unit otherUnit in origin.stencil.battle.units) {
			if (otherUnit.player != origin.player) {
				if (Math.Abs (otherUnit.position - position) < origin.stencil.range) {
					target = otherUnit;
				}
			}
		}
		return target;
	}

	void move(){
		if (origin.player.isLeftPlayer) {
			position += speed;
		} else {
			position -= speed;
		}

	}

}
