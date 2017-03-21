﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Load new scene
	public void LoadScene( string sceneName ) {
		SceneManager.LoadScene( sceneName );
	}

	// Pause game
	void PauseGame() {
		// TODO: pause game
	}
}
