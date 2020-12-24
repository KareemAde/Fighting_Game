using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour
{ // Fighter State Checks

    public bool isHit;
    public bool isCrouching;
    public bool isAir;
    public bool isBlocking;
    public bool isAttacking;
    public bool isFrameCancellable;
    public enum attckDirection
    {
        High,
        Mid,
        Low,
        Overhead
    };
    public attckDirection AttackDirection;

    // Movement
    private Rigidbody controller;
    private Vector2 playerVel;

    public int attackFrame;

    public float walkSpeed = 12f;
    public float backWalkSpeed;
    public float runSpeed;
    public float jumpHeight;

    public bool Function()
    {
        return isHit;
    }

    void FixedUpdate()
    {
        Movement();
        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        //controller.AddForce(movement * walkSpeed);

    }

    private void Movement()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        if (moveHorizontal != 0 && moveVertical == 0)
        {
            if (moveHorizontal > 0)
                Debug.Log("Right");
            else
                Debug.Log("Left");
        }
        if (moveVertical != 0 && moveHorizontal == 0)
        {
            if (moveVertical > 0)
                Debug.Log("Up");
            else
                Debug.Log("Down");
        }
        if (moveVertical != 0 && moveVertical != 0)
        {
            if (moveHorizontal == 1 && moveVertical == 1)
                Debug.Log("Top Right");
            else if (moveHorizontal == 1 && moveVertical == -1)
                Debug.Log("Bottom Right");
            else if (moveHorizontal == -1 && moveVertical == -1)
                Debug.Log("Down Left");
            else if (moveHorizontal == -1 && moveVertical == 1)
                Debug.Log("Top Left");
        }

    }
    void Update()
    {

        if (attckDirection.High.Equals(0))
        {

        }
    }
}
