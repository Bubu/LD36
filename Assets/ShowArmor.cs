using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowArmor : MonoBehaviour {
	Image image;
	public DesignScript ds;
	public int blueprintNo;

	// Use this for initialization
	void Start () {
		ds = GameObject.Find ("InitDesign").GetComponent<DesignScript> ();
		image = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		Texture2D activeArmorTex = GameResources.Instance.armorTexList [ds.warplan.blueprints[blueprintNo].armor.getTexIndex()];
			image.sprite = Sprite.Create(activeArmorTex,new Rect(0,0,activeArmorTex.width,activeArmorTex.height),new Vector2(0,0),activeArmorTex.width);
	}
}
