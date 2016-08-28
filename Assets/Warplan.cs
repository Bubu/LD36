using UnityEngine;
using System.Collections;

public class Warplan {
	public Blueprint[] blueprints;

	public Warplan(){
		blueprints = new Blueprint[3];
		for( int i = 0; i<blueprints.Length; i++) {
			blueprints[i] = new Blueprint ();
		}
	}
}
