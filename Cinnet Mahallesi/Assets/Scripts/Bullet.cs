using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 500f;
    public int damage = 25;
    [SerializeField] private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed * Time.deltaTime;
    }

    void Update()
    {
        StartCoroutine(DeleteBullet());
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Enemy enemy = col.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
        
    }

    IEnumerator DeleteBullet()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
