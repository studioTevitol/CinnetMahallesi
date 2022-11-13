using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmController : MonoBehaviour
{
    public Rigidbody2D playerRb;
    private Vector2 _mousePos;
    private Vector2 _mouseDirection;
    void Start()
    {
        
    }

    void Update()
    {
        _mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _mouseDirection = _mousePos - (Vector2) transform.position;
        transform.right = _mouseDirection;
        if (_mouseDirection.x <= -0.40 || _mouseDirection.x >= 0.40)
        {
            if (_mouseDirection.x < 0)
            {
                playerRb.transform.localScale = new Vector3(-8, 8, 0);
                transform.localScale = new Vector3(-1, -1, 0);
            }
            else
            {
                playerRb.transform.localScale = new Vector3(8, 8, 0);
                transform.localScale = new Vector3(1, 1, 0);
            }
        }
    }
}
