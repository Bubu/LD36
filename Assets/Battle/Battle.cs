using UnityEngine;
using System;
using System.Collections.Generic;

public class Battle : MonoBehaviour
{
	public BattleField battleField;
	public Warplan[] warplans;
	public List<Unit> units;
	public List<Projectile> projectiles;

	void Start ()
	{
		this.battleField = new BattleField();
		this.warplans = new Warplan[2];
		warplans [0] = new Warplan ();
		warplans [1] = new Warplan ();
		units = new List<Unit>();
		projectiles = new List<Projectile>();
	}

	public void step(){
		//check for unit spawm
		foreach( Unit unit in units){
			unit.step ();
		}
		foreach( Projectile projectile in projectiles){
			projectile.step ();
		}
		checkWin ();
	}

	private void checkWin(){
		//show win
	}
}