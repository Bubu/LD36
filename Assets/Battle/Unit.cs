using System;

public class Unit
{
	public Stencil stencil;
	public int curHp;
	private int loadStep;

	public Unit (Stencil stencil)
	{
		this.stencil = stencil;
		this.curHp = stencil.hp;
		this.loadStep = 0;
	}

	public void step(){
		//Do stuff
	}
}
