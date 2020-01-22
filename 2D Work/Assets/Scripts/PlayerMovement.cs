using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 movement = Vector2.zero;
    public float speed = 50f;
    bool facing = true;
    public Animator animator;
    public Joystick joystick;
    private bool isjumping;
    public float jumpSpeed = 10f;
    void Update()
    {
        movement.x = joystick.Horizontal;
        movement.y = joystick.Vertical;

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", 0f);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if(movement.x > 0 && !facing)
        {
            Flip();
        }
        if(movement.x < 0 && facing)
        {
            Flip();
        }
        if(movement.y > 0.8 && !isjumping)
        {
            Jump();
        }

    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    void Flip()
    {
        facing = !facing;
        Vector3 xMirror = transform.localScale;
        xMirror.x *= -1;
        transform.localScale = xMirror;
    }

    void Jump()
    {
        rb.AddForce(movement * jumpSpeed * Time.fixedDeltaTime, ForceMode2D.Impulse);
    }
}
