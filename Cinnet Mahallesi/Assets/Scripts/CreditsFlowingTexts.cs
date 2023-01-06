using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsFlowingTexts : MonoBehaviour
{
    void Start()
    {
        
    }


    void Update()
    {
        if (transform.position.y >= 1300)
        {
            SceneManager.LoadScene("mainmenu_scene");
        }
    }
}
