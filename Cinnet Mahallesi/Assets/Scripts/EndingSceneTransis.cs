using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingSceneTransis : MonoBehaviour
{
    public CharacterMovement player;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (player.endingNumber == 0)
        {
            SceneManager.LoadScene("Cathedral_Good");
        }
        else
        {
            SceneManager.LoadScene("arena3");
        }
    }
}
