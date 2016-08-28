using System;
using UnityEngine;

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
		position = stencil.player.spawnPosition;
		float x = (float)position*10;
		gameObject.transform.position = new Vector3 (x, 0, 0);
	}

	public void step(){
		//Do stuff
	}

	public int checkDistance(){
		return Math.Abs((Convert.ToInt32(target) * 1000) - position);
	}
}
