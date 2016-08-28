using System;

public abstract class Projectile
{	
	public int speedX;
	public int speedY;
	public int gravity;
	public int livingTime;
	public bool colatteral;
	public Unit origin;
	public Unit target;
	public bool dead;

	public abstract void step();
}
