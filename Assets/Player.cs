using UnityEngine;
using System.Collections;

public class Player  {
	public Warplan warplan;
	public Stencil[] stencils;
	public int spawnPosition;

	public Player(){
		this.warplan = new Warplan();
		this.stencils = new Stencil[3];
		for (int i = 0; i < stencils.Length; i++) {
			stencils [i] = new Stencil (warplan.blueprints[i]);
		}
	}
	public Player(Warplan warplan){
		this.warplan = warplan;
		this.stencils = new Stencil[3];
		for (int i = 0; i < stencils.Length; i++) {
			stencils [i] = new Stencil (warplan.blueprints[i]);
		}
	}
}
