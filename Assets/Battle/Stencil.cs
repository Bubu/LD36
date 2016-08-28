using UnityEngine;
using System.Collections;
using System;

public class Stencil {

	public int hp;
	public float speed;
	public Sprite sprite;
	public int buildStep;
	public int buildTime;
	public float damage;
	public Player player;
	//public Blueprint blueprint;

	public Stencil(Blueprint blueprint){
		this.hp = blueprint.armor.getHp ();
		this.speed = blueprint.getSpeed();
		this.damage = blueprint.getDamage ();
		this.buildTime = blueprint.getBuildTime ();

		this.buildStep = 0;

		Texture2D activeWheelTex = GameResources.Instance.wheelTexList [blueprint.wheel.getTexIndex()];
		Texture2D activeArmorTex = GameResources.Instance.armorTexList [blueprint.armor.getTexIndex()];
		Texture2D activeWeaponTex = GameResources.Instance.weaponTexList [blueprint.weapon.activeAmmo.getTexIndex()];

		this.sprite = createSprite (activeWeaponTex, activeArmorTex, activeWheelTex);
	}

	public Unit step(){
		buildStep = (buildStep + 1)%buildTime;
		if (buildStep == 0) {
			return new Unit (this);
		} else {
			return null;
		}
			
	}

	private Sprite createSprite(Texture2D weaponTex, Texture2D armorTex, Texture2D wheelTex){
		Texture2D combinedTex = CombineTextures (weaponTex, armorTex);
		combinedTex = CombineTextures (combinedTex, wheelTex);
		sprite = Sprite.Create(combinedTex,new Rect(0,0,combinedTex.width,combinedTex.height),new Vector2(0,0),combinedTex.width);
		return sprite;
		}

		public static Texture2D CombineTextures(Texture2D aBaseTexture, Texture2D aToCopyTexture)
		{
			int aWidth = aBaseTexture.width;
			int aHeight = aBaseTexture.height;
			Texture2D aReturnTexture = new Texture2D(aWidth, aHeight, TextureFormat.RGBA32, false);

			Color[] aBaseTexturePixels = aBaseTexture.GetPixels();
			Color[] aCopyTexturePixels = aToCopyTexture.GetPixels();
			Color[] aColorList = new Color[aBaseTexturePixels.Length];
			int aPixelLength = Math.Min(aBaseTexturePixels.Length, aCopyTexturePixels.Length);

			//Debug.Log (aPixelLength);
			//Debug.Log (aCopyTexturePixels.Length);

			for(int p = 0; p < aPixelLength; p++)
			{
				aColorList[p] = Color.Lerp(aBaseTexturePixels[p], aCopyTexturePixels[p], aCopyTexturePixels[p].a);
			}

			aReturnTexture.SetPixels(aColorList);
			aReturnTexture.Apply(false);

			return aReturnTexture;
		}		
}
