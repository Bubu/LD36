using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowWheels : MonoBehaviour {

	public DesignScript ds;
	Image image;
	public int blueprintNo;

	// Use this for initialization
	void Start () {
		ds = GameObject.Find ("InitDesign").GetComponent<DesignScript> ();
		image = GetComponent<Image> ();
	}

	void Update () {
		Texture2D activeWheelTex = GameResources.Instance.wheelTexList [ds.warplan.blueprints[blueprintNo].wheel.getTexIndex()];
			image.sprite = Sprite.Create(activeWheelTex,new Rect(0,0,activeWheelTex.width,activeWheelTex.height),new Vector2(0,0),activeWheelTex.width);
	}
}
