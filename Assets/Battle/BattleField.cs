using System.Collections;

public class BattleField {

	Lane[] lanes;
	int width = 1000;

	public BattleField () {
		lanes = new Lane[6];
		for (int i = 0; i < lanes.Length; i++) {
			lanes [i] = new Lane ();
		}
	}
}
