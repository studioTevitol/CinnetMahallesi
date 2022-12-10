using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceScreen : MonoBehaviour
{
    public GameObject splash;
    public CharacterMovement player;
    
    public void ShowSplash()
    {
        splash.SetActive(true);
    }

    public void HideSplash()
    {        
        splash.SetActive(false);
    }

    public void NihilistEnding()
    {
        player.transform.position = new Vector3(-26.5f,-1f,0f);
    }

    public void GoodEnding()
    {
        player.endingNumber = 0;
    }

    public void BadEnding()
    {
        player.endingNumber = 1;
    }
}
