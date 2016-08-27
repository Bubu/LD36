using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Combine : MonoBehaviour {


	public DesignScript ds;
	Image image;

	// Use this for initialization
	void Start () {
		ds = GameObject.Find ("InitDesign").GetComponent<DesignScript> ();
		image = GetComponent<Image> ();
	}

	void Update () {
		if (ds.activeBlueprint!=null){
			Texture2D activeWheelTex = GameResources.Instance.wheelTexList [ds.activeBlueprint.wheel.texIndex];
			Texture2D activeArmorTex = GameResources.Instance.armorTexList [ds.activeBlueprint.armor.texIndex];
			Texture2D activeWeaponTex = GameResources.Instance.weaponTexList [ds.activeBlueprint.weapon.ammo.texIndex];

			Texture2D combinedTex = CombineTextures (activeWeaponTex, activeArmorTex);
			combinedTex = CombineTextures (combinedTex, activeWheelTex);

			image.sprite = Sprite.Create(combinedTex,new Rect(0,0,combinedTex.width,combinedTex.height),new Vector2(0,0),combinedTex.width);

		}
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
