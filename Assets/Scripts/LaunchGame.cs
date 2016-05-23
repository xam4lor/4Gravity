using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LaunchGame : MonoBehaviour {
	public void launchGame() {
		StartCoroutine(Go(1.8F, "Game"));
	}

	public void reLaunchGame() {
		StartCoroutine(Go(1.1F, "Game"));
	}

	public void goMenu() {
		StartCoroutine(Go(0.8F, "Accueil"));
	}

	public void goOptions() {
		StartCoroutine(Go(0.5F, "Settings"));
	}

	IEnumerator Go(float sec, string sceneName) {
		yield return new WaitForSeconds(sec);

		SceneManager.LoadScene (sceneName);
	}
}
