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
		SceneManager.LoadScene("sandbox-credits");
	}

	public void ExitGame()
	{
		Application.Quit();
	}
}
