﻿using UnityEngine;
using System.Collections;

public class ObstaclesMove : MonoBehaviour {
	public float deplacementVitesse;

	void Update () {
		transform.position.Set (-200, transform.position.y, transform.position.z);
		transform.Translate (new Vector3 (deplacementVitesse, 0, 0));

		if(transform.position.x >= 7) {
			Destroy (transform.gameObject);
		}
	}
}
