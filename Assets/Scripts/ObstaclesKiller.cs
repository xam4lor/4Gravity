using UnityEngine;
using System.Collections;

public class ObstaclesKiller : MonoBehaviour {
	void OnCollisionEnter(Collision coll) {
		if (coll.gameObject.tag == "obstacle") {
			Destroy (coll.gameObject);
		} else {
			Debug.Log (coll);
		}
	}
}
