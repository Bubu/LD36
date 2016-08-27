using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowWheels : MonoBehaviour {

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
			image.sprite = Sprite.Create(activeWheelTex,new Rect(0,0,activeWheelTex.width,activeWheelTex.height),new Vector2(0,0),activeWheelTex.width);

		}
	}
}
