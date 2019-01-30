using UnityEngine.SceneManagement;
using UnityEngine;

public class DeathTouch : MonoBehaviour {

	//losing game by touching
	void OnCollisionEnter (Collision collide) {
		if (collide.gameObject.tag == "Player") {

			Invoke ("End", 0.1f);
		}
	}
	void End () {
		SceneManager.LoadScene("Game Over");
	}
}
