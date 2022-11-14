using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmController : MonoBehaviour
{
    public Transform player;
    private Vector2 _mousePos;
    private Vector2 _mouseDirection;

    void Update()
    {
        _mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _mouseDirection = _mousePos - (Vector2) transform.position;
        transform.right = _mouseDirection;
        if (_mouseDirection.x <= -0.40 || _mouseDirection.x >= 0.40)
        {
            if (_mouseDirection.x < 0)
            {
                player.localScale = new Vector3(-4, 4, 0);
                transform.localScale = new Vector3(4, -4, 0);
            }
            else
            {
                player.localScale = new Vector3(4, 4, 0);
                transform.localScale = new Vector3(4, 4, 0);
            }
        }
    } 
}