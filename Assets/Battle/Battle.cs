using UnityEngine;
using UnityEngine.UI;
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
	public int leftHomePosition = 0;
	public int rightHomePosition = 1000;
	public GameObject endImage;
	public GameObject uploadButton;

	void Start ()
	{
		this.battleField = new BattleField();
		players = new Player[2];
		players[0] = new Player(true, this);
		players[1] = new Player(false, this);
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

	public void checkWin(){
		Player winner = null;
		foreach( Unit unit in units){
			if (unit.checkDistance () <= 0) {
				winner = unit.player;
			}
		}
		if (winner != null) {
			isRunning = false;
			showWinner (winner);
		}
	}

	public void FixedUpdate(){
		if (isRunning) {
			step ();
		}
	}

	public void startBattle(){
		this.isRunning = true;
		GameObject.Find ("StartButton").SetActive (false);
	}

	private void showWinner (Player winner)
	{
		Image image = endImage.GetComponent<Image>();
		if (players [0] == winner) {
			image.sprite = GameResources.Instance.getSprite(GameResources.Instance.win);
		} else {
			image.sprite = GameResources.Instance.getSprite(GameResources.Instance.lose);
		}
		uploadButton.SetActive (true);
		image.gameObject.SetActive (true);
	}
}