using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConverstaionManage : MonoBehaviour
{
    public void GoOutside()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
