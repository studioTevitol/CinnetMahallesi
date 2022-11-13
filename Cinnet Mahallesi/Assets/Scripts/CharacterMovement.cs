using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    public bool canJump = true;
    public bool canMove = true;
    public float speed;
    public float jumpSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (Input.GetKey(KeyCode.Space)) Jump();
    }

    void Jump()
    {
        if (canJump)
        {
            canJump = false;
            rb.velocity = Vector2.up * jumpSpeed;
            //rb.AddForce(Vector2.up*jumpSpeed, ForceMode2D.Force);
            //animator.SetBool("isJumping", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Platform"))
        {
            canJump = true;
        } 
    }
}
