using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Movement
{
    [System.Serializable]
    public class Stamina
    {
        [Range(1f, 100f)] public float amount;
        [Range(.1f, 100f)] public float staminaLose;
        [Range(.01f, 3f)] public float loseTime;
        [Range(.1f, 5f)] public float recoveryTime;
        [Range(.1f, 100f)] public float recoveryAmount;
        [Range(.1f, 20f)] public float catchBreathTime;
    }

    public Stamina stamina;
    [Range(1f, 10f)] public float walkSpeed;
    [Range(1f, 15f)] public float runSpeed;
    [Range(1f, 10f)] public float turnSpeedX;
    [Range(1f, 10f)] public float turnSpeedY;
    [Range(1f, 20f)] public float gravity;


    [HideInInspector] public Vector3 moveDirecetion;
}