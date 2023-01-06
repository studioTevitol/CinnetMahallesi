using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
	public void PlayGame()
	{
		SceneManager.LoadScene("House_Messy");
	}
	public void Credits()
	{
		SceneManager.LoadScene("credits_scene");
	}

	public void ExitGame()
	{
		Application.Quit();
	}
}
