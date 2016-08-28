using UnityEngine;
using UnityEngine.SceneManagement; 
using System.Collections;
using System.Collections.Generic;
using System;

public class DesignScript : MonoBehaviour {

	public Warplan warplan;
	//public Blueprint activeBlueprint;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this);
		warplan = new Warplan();
		//activeBlueprint = warplan.blueprints [0];
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void selActiveBlueprint(int blueprintIndex){
		//activeBlueprint = warplan.blueprints [blueprintIndex];
	}

	public void selectWeapon1(int weaponIndex){
		selectWeapon (weaponIndex, 0);
	}
	public void selectWeapon2(int weaponIndex){
		selectWeapon (weaponIndex, 1);
	}
	public void selectWeapon3(int weaponIndex){
		selectWeapon (weaponIndex, 2);
	}

	public void selectWeapon(int weaponIndex, int blueprintNo){
		Weapon selectedWeapon = null;
		if (weaponIndex == 0) {
			selectedWeapon = new Catapult ();
		}
		else if (weaponIndex == 1) {
			selectedWeapon = new Ballista ();
		}
		else {
			selectedWeapon = new Ram ();
		}
		warplan.blueprints[blueprintNo].weapon = selectedWeapon;}

	public void selectArmor1(int armorIndex){
		selectArmor (armorIndex, 0);
	}
	public void selectArmor2(int armorIndex){
		selectArmor (armorIndex, 1);
	}
	public void selectArmor3(int armorIndex){
		selectArmor (armorIndex, 2);
	}
	public void selectArmor(int armorIndex, int blueprintNo){
		Armor selectedArmor = null;
		if (armorIndex == 0) {
			selectedArmor = new Armor1 ();
		}
		else if (armorIndex == 1) {
			selectedArmor = new Armor2 ();
		}
		else {
			selectedArmor = new Armor3 ();
		}
		warplan.blueprints[blueprintNo].armor = selectedArmor;}

	public void selectAmmo1(int ammoIndex){
		selectAmmo (ammoIndex, 0);
	}
	public void selectAmmo2(int ammoIndex){
		selectAmmo (ammoIndex, 1);
	}
	public void selectAmmo3(int ammoIndex){
		selectAmmo (ammoIndex, 2);
	}
	public void selectAmmo(int ammoIndex, int blueprintNo){
		warplan.blueprints[blueprintNo].weapon.selectAmmo (ammoIndex);
	}

	public void selectWeel1(int wheelIndex){
		selectWheel (wheelIndex, 0);
	}
	public void selectWeel2(int wheelIndex){
		selectWheel (wheelIndex, 1);
	}
	public void selectWeel3(int wheelIndex){
		selectWheel (wheelIndex, 2);
	}
	public void selectWheel(int wheelIndex, int blueprintNo){
		Wheel selectedWheel = null;
		if (wheelIndex == 0) {
			selectedWheel = new Wheel1 ();
		}
		else if (wheelIndex == 1) {
			selectedWheel = new Wheel2 ();
		}
		else {
			selectedWheel = new Wheel3 ();
		}
		warplan.blueprints[blueprintNo].wheel = selectedWheel;
	}

	public void startGame(){
		SceneManager.LoadScene ("Battle");
	}
}
