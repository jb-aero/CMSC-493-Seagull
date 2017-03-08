﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void ChangeScene(string name)
	{
		Scene myScene = SceneManager.GetSceneByName (name);
		if (!myScene.isLoaded)
		{
			SceneManager.LoadScene (name);
		}

		if (myScene.isLoaded && myScene.IsValid ())
		{
			SceneManager.SetActiveScene (myScene);
		}
	}

	public void Exit()
	{
		Scene current = SceneManager.GetActiveScene ();
		if (current.buildIndex == 0)
		{
			Application.Quit ();
		}
		else
		{
			SceneManager.SetActiveScene (SceneManager.GetSceneAt (0));
		}
	}
}