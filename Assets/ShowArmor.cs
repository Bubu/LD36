using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowArmor : MonoBehaviour {
	Image image;
	public DesignScript ds;

	// Use this for initialization
	void Start () {
		ds = GameObject.Find ("InitDesign").GetComponent<DesignScript> ();
		image = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (ds.activeBlueprint!=null){

			//Debug.Log ("Hello!");
			/*
			Texture2D activeArmorTex = GameResources.Instance.armorTexList [ds.activeBlueprint.armor.texIndex];
			Texture activeWeaponTex = GameResources.Instance.weaponTexList [ds.activeBlueprint.weapon.ammo.texIndex];
			Texture activeWheelTex = GameResources.Instance.wheelTexList [ds.activeBlueprint.wheel.texIndex];

			RenderTexture rendTex = new RenderTexture(activeArmorTex.width, activeArmorTex.height, 24); 
			rendTex.Create ();

			Graphics.Blit (activeArmorTex+activeWeaponTex, rendTex);
			//Graphics.Blit (activeWeaponTex, rendTex);
			//Graphics.Blit (activeWheelTex, rendTex);

			Texture2D designTexture = new Texture2D(300, 227);
			RenderTexture.active = rendTex;

			designTexture.ReadPixels(new Rect(0, 0, rendTex.width, rendTex.height), 0, 0);
			designTexture.Apply();

			designSprite = Sprite.Create(designTexture,new Rect(0,0,300,227),new Vector2(0,0),300);
			*/
			Texture2D activeArmorTex = GameResources.Instance.armorTexList [ds.activeBlueprint.armor.texIndex];
			image.sprite = Sprite.Create(activeArmorTex,new Rect(0,0,activeArmorTex.width,activeArmorTex.height),new Vector2(0,0),activeArmorTex.width);

		}
	}
}
