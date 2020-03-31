using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedController : PlayerController
{

    private void Update()
    {
        if (redInPlay)
        {
            //Jump mechanics
            if (Input.GetButton("Jump") && IsGrounded == true)
            {
                Jump();

            }
        }
    }
    void FixedUpdate()
    {
        if (redInPlay)
        {
            IsGrounded = Physics2D.OverlapCircle(GroundCheck.position, CheckRadius, Ground);
            //Movement
            MoveInput = Input.GetAxisRaw("Horizontal");
            rb.velocity = new Vector2(MoveInput * speed, rb.velocity.y);
            Animator.SetFloat("Speed", Mathf.Abs(MoveInput));
            //Makes the player change animations
            //Fliping right and left


            if (MoveInput > 0 && FacingRight == false)
            {
                Flip();
            }
            else if (MoveInput < 0 && FacingRight == true)
            {
                Flip();
            }

        }
        else
        {
            MoveInput = 0;
            Animator.SetFloat("Speed", Mathf.Abs(MoveInput));
        }
    }
}
