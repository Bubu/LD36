using UnityEngine;
using System.Collections;

public class CatapultProjectile : MonoBehaviour {
	public int position;
	public int targetPosition;
	public int speedX;
	public int speedY;
	public int gravity;
	public int damage;
	public bool dead;
	public Sprite sprite;


	public CatapultProjectile (Unit target, int damage, Texture2D tex)
	{
		this.targetPosition = target.position ;
		this.damage = damage;
		this.dead = false;
		this.sprite = Sprite.Create(tex,new Rect(0,0,tex.width,tex.height),new Vector2(0,0),tex.width);
	}
	
	void step () {

	}

}
