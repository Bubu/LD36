using UnityEngine;
using System;

public class Battle : MonoBehaviour
{
	public BattleField battleField;
	public Warplan[] warplans;

	void Start ()
	{
		this.battleField = new BattleField();
		this.warplans = new Warplan[2];
		warplans [0] = new Warplan ();
		warplans [1] = new Warplan ();
	}

	public void step(){
		
	}
}