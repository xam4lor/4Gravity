using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LaunchGame : MonoBehaviour {
	public void launchGame() {
		SceneManager.LoadScene ("Game");
	}
}
