using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	public static void end () {
		SceneManager.LoadScene ("GameOver");
	}
}
