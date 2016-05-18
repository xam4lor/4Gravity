using UnityEngine;
using System.Collections;

public class ObstaclesMove : MonoBehaviour {
	public float deplacementVitesse;

	void Update () {
		transform.Translate (new Vector3 (deplacementVitesse, 0, 0));

		if (transform.position.x >= 253) {
			transform.position = new Vector3 (0, 0, 0);
		}
	}
}
