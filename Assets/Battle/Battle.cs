using UnityEngine;
using System;
using System.Collections.Generic;

public class Battle : MonoBehaviour
{
	public BattleField battleField;
	public Player[] players;
	public Warplan[] warplans;
	public List<Unit> units;
	public List<Projectile> projectiles;
	private bool isRunning = false;

	void Start ()
	{
		this.battleField = new BattleField();
		players = new Player[2];
		players[0] = new Player();
		players[1] = new Player();
		units = new List<Unit>();
		projectiles = new List<Projectile>();
	}

	public void step(){
		foreach(Player player in players){
			foreach (Stencil stencil in  player.stencils) {
				var newunit = stencil.step ();
				if (newunit != null) {
					units.Add (newunit);
				}
			}
		}
		foreach( Unit unit in units){
			unit.step ();
		}
		foreach( Projectile projectile in projectiles){
			projectile.step ();
		}
		checkWin ();
	}

	private void checkWin(){
		Player winner = null;
		foreach( Unit unit in units){
			if (unit.checkDistance () <= 0) {
				winner = unit.player;
			}
		}
		if (winner != null) {
			isRunning = false;
			//showWinner
		}
	}
}