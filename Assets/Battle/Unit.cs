using System;

public class Unit
{
	public int position;
	public bool target;
	public Player player;

	public Unit ()
	{
		
	}

	public void step(){
		//Do stuff
	}

	public int checkDistance(){
		return Math.Abs((Convert.ToInt32(target) * 1000) - position);
	}
}
