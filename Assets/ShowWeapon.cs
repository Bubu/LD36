using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowWeapon : MonoBehaviour {

	public DesignScript ds;
	Image image;
	public int blueprintNo;

	// Use this for initialization
	void Start () {
		ds = GameObject.Find ("InitDesign").GetComponent<DesignScript> ();
		image = GetComponent<Image> ();
	}
	
	void Update () {
		Texture2D activeWeaponTex = GameResources.Instance.weaponTexList [ds.warplan.blueprints[blueprintNo].weapon.activeAmmo.getTexIndex()];
			image.sprite = Sprite.Create(activeWeaponTex,new Rect(0,0,activeWeaponTex.width,activeWeaponTex.height),new Vector2(0,0),activeWeaponTex.width);
	}
}
