using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public bool isHit;
    public bool isBlocked;

    public int attackDamage;
    public int blockedDamage;
    public int frameCounter;
    public int hitStun;
    public int blockStun;
    public int totalFrames;

    enum hitType
    {
        Hit,
        Grab
    };

    public Vector2 launchAngle;

}
