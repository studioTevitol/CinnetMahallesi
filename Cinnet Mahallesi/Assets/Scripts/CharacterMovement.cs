using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Shoot shootManager;
    public bool canJump = true;
    public bool canMove = true;
    public float speed;
    public float jumpSpeed;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        shootManager = GetComponent<Shoot>();
        
    }

    void FixedUpdate()
    {
        if(canMove) {
            float moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.Space)) Jump();
        if (canMove && Input.GetKeyDown(KeyCode.Mouse0))
        {
            shootManager.Fire();
        }
    }

    void Jump()
    {
        if (canMove && canJump)
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