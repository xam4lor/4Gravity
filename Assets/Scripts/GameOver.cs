using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	public static void end () {
		Debug.Log ("Game Over");

		SceneManager.LoadScene ("GameOver");
		SceneManager.UnloadScene ("Game");
	}
}
