using System.Collections;

public class Blueprint {

	public Wheel wheel;
	public Armor armor;
	public Weapon weapon;

	public Blueprint() {
		this.armor = new Armor1 ();
		this.wheel = new Wheel1 ();
		this.weapon = new Catapult ();
	}


	public float getBuildTime(){
		return  
	}
}
