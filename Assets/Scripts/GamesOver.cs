using UnityEngine;
using UnityEngine.SceneManagement;

public class GamesOver : MonoBehaviour {

	bool gameIsOver = false;

	// Use this for initialization
	void GameOver () {

		if (gameIsOver == false) {
			gameIsOver = true;
			Invoke ("Restart", 1f);
		}
	}


	void Restart () {
		SceneManager.LoadScene("GameOver");
	}
}
