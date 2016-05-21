using UnityEngine;
using System.Collections;

[System.Serializable]
public class Obstacles {
	public GameObject obs1;
	public GameObject obs2;
	public GameObject obs3;
	public GameObject obs4;
}

public class SpawnObstacles : MonoBehaviour {
	public Obstacles obstacles;

	private int obsLength = 4;

	void Start () {
		InvokeRepeating("CreateObstacle", 2.5f, 2f);
	}

	void CreateObstacle () {
		int r = Random.Range (1, obsLength);

		switch(r) {
		case 1:
			GameObject.Instantiate (obstacles.obs1);
			break;
		case 2:
			GameObject.Instantiate (obstacles.obs2);
			break;
		case 3:
			GameObject.Instantiate (obstacles.obs3);
			break;
		case 4:
			GameObject.Instantiate (obstacles.obs4);
			break;
		}
	}
}
