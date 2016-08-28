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


	public int getBuildTime(){
		return (int)(this.weapon.getBaseTime () * getTimefactorForLevel(armor.getLevel()) * getTimefactorForLevel(wheel.getLevel())* getTimefactorForLevel(weapon.activeAmmo.getLevel())); 
	}

	private float getTimefactorForLevel(int level){
		return 1f + 0.5f * level;
	}
	public float getSpeed(){
		return weapon.getBaseSpeed() * wheel.getBaseSpeed();
	}
	public float getDamage(){
		return weapon.activeAmmo.getDamage ();
	}
	public int getRange(){
		return weapon.getRange ();
	}
	public int getLoadTime(){
		return weapon.getLoadTime ();
	}
}
