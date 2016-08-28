using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowWeapon : MonoBehaviour {

	public DesignScript ds;
	Image image;

	// Use this for initialization
	void Start () {
		ds = GameObject.Find ("InitDesign").GetComponent<DesignScript> ();
		image = GetComponent<Image> ();
	}
	
	void Update () {
		if (ds.activeBlueprint!=null){
			Texture2D activeWeaponTex = GameResources.Instance.weaponTexList [ds.activeBlueprint.weapon.activeAmmo.getTexIndex()];
			image.sprite = Sprite.Create(activeWeaponTex,new Rect(0,0,activeWeaponTex.width,activeWeaponTex.height),new Vector2(0,0),activeWeaponTex.width);

		}
	}
}
