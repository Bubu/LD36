using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class GameResources {

	public static GameResources instance;
	public List<Texture2D> weaponTexList;
	public List<Texture2D> wheelTexList;
	public List<Texture2D> armorTexList;

	private GameResources(){
		weaponTexList = new List<Texture2D> (new Texture2D [] {
			loadTex ("katapult_schlecht"),
			loadTex ("katapult_gut"),
			loadTex ("katapult_fehlt"),
			loadTex ("baliste_schlecht"),
			loadTex ("baliste_gut"),
			loadTex ("baliste_fehlt"),
			loadTex ("rammbock_schlecht"),
			loadTex ("rammbock_gut"),
			loadTex ("rammbock_fehlt"),
		});
		wheelTexList = new List<Texture2D> (new Texture2D [] {
			loadTex ("rad_schlecht"),
			loadTex ("rad_gut")
		});
		armorTexList = new List<Texture2D> (new Texture2D [] {
			loadTex ("rahmen_schlecht"),
			loadTex ("rahmen_gut")
		});
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

}
