using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Movement
{
    [System.Serializable]
    public class Stamina
    {
        [Range(1, 100)] public int maxAmount;
        [Range(1f, 100f)] public float amount;
        [Range(.01f, 100f)] public float staminaLose;
        [Range(.01f, 3f)] public float loseTime;
        [Range(.01f, 5f)] public float recoveryTime;
        [Range(.01f, 100f)] public float recoveryAmount;
        [Range(.01f, 20f)] public float catchBreathTime;
    }

    [Range(1f, 10f)] public float sneakSpeed;       //Not implemented && Maybe useless
    [Range(1f, 10f)] public float walkSpeed;
    [Range(1f, 15f)] public float runSpeed;
    [Range(1f, 15f)] public float crouchSpeed;      //Not implemented 
    [Range(1f, 20f)] public float turnSpeedX;
    [Range(1f, 20f)] public float turnSpeedY;

    public Stamina stamina;
    
    [Space, Range(1f, 20f)] public float gravity = 9.81f;

    public bool isDead = false;

    [HideInInspector] public Vector3 moveDirecetion;
}