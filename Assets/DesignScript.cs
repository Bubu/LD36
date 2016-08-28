using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class DesignScript : MonoBehaviour {

	public Warplan warplan;
	public Blueprint activeBlueprint;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this);
		warplan = new Warplan();
		activeBlueprint = warplan.blueprints [0];
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void selActiveBlueprint(int blueprintIndex){
		activeBlueprint = warplan.blueprints [blueprintIndex];
	}

	public void selectWeapon(int weaponIndex){
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
		activeBlueprint.weapon = selectedWeapon;}

	public void selectArmor(int armorIndex){
		Armor selectedArmor = null;
		if (armorIndex == 0) {
			selectedArmor = new Armor1 ();
		}
		else if (armorIndex == 1) {
			selectedArmor = new Armor2 ();
		}
		else {
			selectedArmor = new Armor2 ();
		}
		activeBlueprint.armor = selectedArmor;}

	public void selectAmmo(int ammoIndex){
		activeBlueprint.weapon.selectAmmo (ammoIndex);
	}

	public void selectWheel(int wheelIndex){
		Wheel selectedWheel = null;
		if (wheelIndex == 0) {
			selectedWheel = new Wheel1 ();
		}
		else if (wheelIndex == 1) {
			selectedWheel = new Wheel2 ();
		}
		else {
			selectedWheel = new Wheel2 ();
		}
		activeBlueprint.wheel = selectedWheel;}
}
