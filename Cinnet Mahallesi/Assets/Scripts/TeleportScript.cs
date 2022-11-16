using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public GameObject player;
    public GameObject target;
    void Start()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
		player.transform.position = target.transform.position;
		Debug.Log("degiyo");
	}

}  
