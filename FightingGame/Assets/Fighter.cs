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

    public int attackFrame;

    public float walkSpeed = 12f;
    public float backWalkSpeed;
    public float runSpeed;
    public float jumpHeight;

    public bool Function()
    {
        return isHit;
    }

    // Update is called once per frame
    void Update()
    {
        if (attckDirection.High.Equals(0))
        {

        }
    }
}
