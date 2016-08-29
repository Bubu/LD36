using UnityEngine;
using System.Collections;
using System;

public class CatapultProjectile : Projectile {
	public int position;
	public int targetPosition;
	public double Vx;
	public double Vy;
	public double g;
	public int damage;
	public bool dead;
	public Sprite sprite;
	public int maxRange = 10;
	public int velocity = 2;
	public double positionX;
	public double positionY;
	public Unit origin;
	public int collArea = 1;

	public CatapultProjectile (Unit target, Unit origin, int damage, int maxRange, Texture2D tex)
	{	
		this.origin = origin;
		this.targetPosition = target.position ;
		this.damage = damage;
		this.dead = false;
		this.sprite = Sprite.Create(tex,new Rect(0,0,tex.width,tex.height),new Vector2(0,0),tex.width);
		this.maxRange = maxRange;

		int range = target.position - origin.position;
		double relRange = (double)range  / maxRange;
		double veloSq = (double)(velocity * velocity);
		this.g = veloSq / maxRange;

		this.Vy = velocity * Math.Sqrt ((1 - Math.Sqrt (1 - relRange*relRange)) / 2);
		this.Vx = veloSq * relRange / (2 * Vy);
		this.positionX = origin.position;
		this.positionY = 0;

	}
	
	public override void step () {
		positionX += Vx;
		positionY += Vy;
		Vy -= g;
		if (positionY <= 0) {
			explode ();
			dead = true;
		}
	}
	private void explode(){
		foreach (Unit otherUnit in origin.stencil.battle.units) {
			if (otherUnit.stencil.player != origin.stencil.player) {
				if (Math.Abs (otherUnit.position - position) < collArea) {
					otherUnit.makeDamage(damage);
				}
			}
		}
	}
}
