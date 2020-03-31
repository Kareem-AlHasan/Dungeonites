using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Speed and Movements
    public float speed;
    public float JumpForce;
    public bool FacingRight = true;

    //Ground Check
    public float CheckRadius;
    public LayerMask Ground;
    public Transform GroundCheck;

    //Animation

    public bool redInPlay;
    public bool yellowInPlay;
    public bool greenInPlay;
    public bool blueInPlay;

    [HideInInspector]
    public Rigidbody2D rb;
    public Animator Animator;
    public bool IsGrounded;
    public float MoveInput;



    public void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();

    }

    //Flip function
    public void Flip()
    {
        FacingRight = !FacingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    public void Jump()
    {

        rb.velocity = Vector2.up * JumpForce;

    }
}
