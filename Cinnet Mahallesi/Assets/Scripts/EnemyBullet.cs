using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10000f;
    [SerializeField] private GameObject target; 
    [SerializeField] private Rigidbody2D bulletRb;
    private Vector2 moveDirection;
    void Start()
    {
        //moveDirection = (target.transform.position - transform.position).normalized ;
        //bulletRb.velocity = new Vector2(moveSpeed, 0);
        bulletRb.velocity = transform.right * moveSpeed; 
        Destroy(gameObject, 4f);
        
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Hit!");
            Destroy(gameObject);
        }
    }
}
