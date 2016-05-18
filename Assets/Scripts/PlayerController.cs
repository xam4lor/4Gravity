using UnityEngine;
using System.Collections;

[System.Serializable]
public class Positions {
	public Haut haut;
	public Bas bas;
	public Droite droite;
	public Gauche gauche;
}

[System.Serializable]
public class HauteurSaut {
	public float haut;
	public float bas;
	public float droite;
	public float gauche;
}

public class PlayerController : MonoBehaviour {
	public Positions positions;
	public HauteurSaut hauteurSaut;
	public float tempsSaut;

	private Rigidbody rb;
	private int currentPosition;

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

	void FixedUpdate () {
		if (Input.GetButton ("Droite")) {
			goToPosition (1);
		}
		else if (Input.GetButton ("Gauche")) {
			goToPosition (2);
		}
		else if (Input.GetButton ("Haut")) {
			goToPosition (3);
		}
		else if (Input.GetButton ("Bas")) {
			goToPosition (4);
		}
		else if (Input.GetButton ("Jump")) {
			jump ();
		}
	}

	private void jump() {
		switch (currentPosition) {
		case 1:
			jumpPosDroiteGo ();
			break;
		case 2:
			jumpPosGaucheGo ();
			break;
		case 3:
			jumpPosHautGo ();
			break;
		case 4:
			jumpPosBasGo ();
			break;
		}
	}

	private void goToPosition(int positionNb) {
		switch (positionNb) {

		case 1:
			rb.position = new Vector3 (positions.droite.x, positions.droite.y, positions.droite.z);
			rb.transform.localEulerAngles = new Vector3(positions.droite.RotationX, positions.droite.RotationY, positions.droite.RotationZ);
			break;

		case 2:
			rb.position = new Vector3 (positions.gauche.x, positions.gauche.y, positions.gauche.z);
			rb.transform.localEulerAngles = new Vector3(positions.gauche.RotationX, positions.gauche.RotationY, positions.gauche.RotationZ);
			break;

		case 3:
			rb.position = new Vector3 (positions.haut.x, positions.haut.y, positions.haut.z);
			rb.transform.localEulerAngles = new Vector3(positions.haut.RotationX, positions.haut.RotationY, positions.haut.RotationZ);
			break;

		case 4:
			rb.position = new Vector3 (positions.bas.x, positions.bas.y, positions.bas.z);
			rb.transform.localEulerAngles = new Vector3 (positions.bas.RotationX, positions.bas.RotationY, positions.bas.RotationZ);
		break;

		default :
			Debug.LogError ("Erreur ligne 56 classe PlayerController");
			break;
		}

		currentPosition = positionNb;
	}

	private void jumpPosHautGo() {
		float high = hauteurSaut.haut;

		rb.position = new Vector3 (rb.position.x, (rb.position.y - high), rb.position.z);

		Invoke ("jumpPosHautCome", tempsSaut);
	}

	private void jumpPosHautCome() {
		float high = hauteurSaut.haut;

		rb.position = new Vector3 (rb.position.x, (rb.position.y + high), rb.position.z);
	}



	private void jumpPosBasGo() {
		float high = hauteurSaut.bas;

		rb.position = new Vector3 (rb.position.x, (rb.position.y + high), rb.position.z);

		Invoke ("jumpPosBasCome", tempsSaut);
	}

	private void jumpPosBasCome() {
		float high = hauteurSaut.bas;

		rb.position = new Vector3 (rb.position.x, (rb.position.y - high), rb.position.z);
	}



	private void jumpPosDroiteGo() {
		float high = hauteurSaut.droite;

		rb.position = new Vector3 (rb.position.x, rb.position.y, (rb.position.z - high));

		Invoke ("jumpPosDroiteCome", tempsSaut);
	}

	private void jumpPosDroiteCome() {
		float high = hauteurSaut.droite;

		rb.position = new Vector3 (rb.position.x, rb.position.y, (rb.position.z + high));
	}



	private void jumpPosGaucheGo() {
		float high = hauteurSaut.gauche;

		rb.position = new Vector3 (rb.position.x, rb.position.y, (rb.position.z + high));

		Invoke ("jumpPosGaucheCome", tempsSaut);
	}

	private void jumpPosGaucheCome() {
		float high = hauteurSaut.gauche;

		rb.position = new Vector3 (rb.position.x, rb.position.y, (rb.position.z - high));
	}
}


[System.Serializable]
public class Haut {
	public float x;
	public float y;
	public float z;

	public float RotationX;
	public float RotationY;
	public float RotationZ;
}

[System.Serializable]
public class Bas {
	public float x;
	public float y;
	public float z;

	public float RotationX;
	public float RotationY;
	public float RotationZ;
}

[System.Serializable]
public class Droite {
	public float x;
	public float y;
	public float z;

	public float RotationX;
	public float RotationY;
	public float RotationZ;
}

[System.Serializable]
public class Gauche {
	public float x;
	public float y;
	public float z;

	public float RotationX;
	public float RotationY;
	public float RotationZ;
}
