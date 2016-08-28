using UnityEngine;
using System.Collections;

public class Player  {
	public Warplan warplan;
	public Stencil[] stencils;
	public int homePosition;
	public Battle battle;
	public bool isLeftPlayer;

	public Player(bool isLeftPlayer, Battle battle){
		this.isLeftPlayer = isLeftPlayer;
		this.warplan = new Warplan();
		this.stencils = new Stencil[3];
		for (int i = 0; i < stencils.Length; i++) {
			stencils [i] = new Stencil (warplan.blueprints[i], this, battle);
		}
		if (isLeftPlayer) {
			this.homePosition = battle.leftHomePosition;
		} else {
			this.homePosition = battle.rightHomePosition;
		}
			
	}


}
