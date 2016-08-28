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

	public void checkWin(){
		Player winner = null;
		foreach( Unit unit in units){
			if (unit.checkDistance () <= 0) {
				winner = unit.player;
			}
		}
		winner = players [0];
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
		Image image = GameObject.Find ("EndImage").GetComponent<Image>();
		image.sprite = Sprite.Create(GameResources.Instance.armorTexList [1],new Rect(0,0,image.preferredWidth,image.preferredHeight),new Vector2(0,0),image.preferredWidth);
		image.gameObject.SetActive (true);
		Text  text = GameObject.Find ("EndText").GetComponent<Text>();
		if (players [0] == winner) {
			text.text = "You Won!";
		} else {
			text.text = "You Lost!";
		}
		GameObject.Find ("UploadtButton").SetActive (true);
	}
}