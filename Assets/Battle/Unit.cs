using System;

public class Unit
{
	public Stencil stencil;
	public int curHp;

	public Unit (Stencil stencil)
	{
		this.stencil = stencil;
		this.curHp = stencil.hp;
	}

	public void step(){
		//Do stuff
	}
}
