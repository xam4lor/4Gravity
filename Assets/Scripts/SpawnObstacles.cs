using UnityEngine;
using System.Collections;

public class SpawnObstacles : MonoBehaviour {
	public GameObject test;

	void Start () {
		InvokeRepeating("CreateObstacle", 2.5f, 2f);
	}

	void CreateObstacle () {
		Instantiate (test);
	}
}
