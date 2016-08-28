using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class GameResources {

	public static GameResources instance;
	public List<Texture2D> weaponTexList;
	public List<Texture2D> wheelTexList;
	public List<Texture2D> armorTexList;
	public Texture2D win;
	public Texture2D lose;

	private GameResources(){
		weaponTexList = new List<Texture2D> (new Texture2D [] {
			loadTex ("katapult_schlecht"),
			loadTex ("katapult_mittel"),
			loadTex ("katapult_gut"),
			loadTex ("baliste_schlecht"),
			loadTex ("baliste_mittel"),
			loadTex ("baliste_gut"),
			loadTex ("rammbock_schlecht"),
			loadTex ("rammbock_mittel"),
			loadTex ("rammbock_gut"),
		});
		wheelTexList = new List<Texture2D> (new Texture2D [] {
			loadTex ("rad_schlecht"),
			loadTex ("rad_mittel"),
			loadTex ("rad_gut")
		});
		armorTexList = new List<Texture2D> (new Texture2D [] {
			loadTex ("rahmen_schlecht"),
			loadTex ("rahmen_mittel"),
			loadTex ("rahmen_gut")
		});

		win = loadTex ("Ende_Win2");
		lose = loadTex ("Ende_lose");
	}
	public static GameResources Instance {
		get {
			if (instance == null) {
				instance = new GameResources ();
			}
			return instance;
		}
	}


	public Texture2D loadTex(String texName){
		Texture2D tex = Resources.Load<Texture2D>(texName);
		return tex;
	}

	public Sprite getSprite(Texture2D tex){
		return Sprite.Create (tex, new Rect(0f,0f,tex.width, tex.height), new Vector2(0.5f,0.5f));
	}

}
