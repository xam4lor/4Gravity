using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	public int vitesse;
	public int vitessePoints;

	private bool action = false;
	private Rigidbody rb;
	private int currentPosition;
	private long points;

	void Start () {
		rb = GetComponent<Rigidbody>();

		currentPosition = 4;
	}

	void OnCollisionEnter(Collision coll) {
		if (coll.gameObject.tag == "obstacle") {
			Destroy (coll.gameObject);

			GameOver.end ();
		}
	}

	void FixedUpdate () { //0.2 sec
		rb.transform.rotation = new Quaternion(0, 0, 0, 0);

		if (!action) {
			if (Input.GetButton ("Droite")) {
				action = true;
				goToPosition (1);
				action = false;
			} else if (Input.GetButton ("Gauche")) {
				action = true;
				goToPosition (2);
				action = false;
			} else if (Input.GetButton ("Haut")) {
				action = true;
				goToPosition (3);
				action = false;
			} else if (Input.GetButton ("Bas")) {
				action = true;
				goToPosition (4);
				action = false;
			}
		}

		points++;

		GameObject.Find ("points").GetComponent<Text> ().text = ("Score : " + (points / vitessePoints));
	}

	private void goToPosition(int positionNb) {
		switch (positionNb) {

		case 1:
			rb.velocity = new Vector3 (0, 0, vitesse);
			break;

		case 2:
			rb.velocity = new Vector3 (0, 0, -vitesse);
			break;

		case 3:
			rb.velocity = new Vector3 (0, vitesse, 0);
			break;

		case 4:
			rb.velocity = new Vector3 (0, -vitesse, 0);
		break;

		default :
			Debug.LogError ("Erreur ligne 56 classe PlayerController");
			break;
		}

		currentPosition = positionNb;
	}
}
