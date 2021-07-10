using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotionScr : MonoBehaviour
{
    [System.Serializable]
    public class ToAdd
    {
        public Transform playerCam;
        public Transform groundCheck;
        [HideInInspector] public CharacterController controller;
        public LayerMask groundMask;
    }

    [Tooltip("Add necessary Objects")] public ToAdd locomotion;
    [Space]
    public Movement movement;

    Vector3 velocity;
    float speed;
    bool sprint = false;
    bool recoverStamina = false;
    bool recoverAir = false;
    float maxStamina;


    float xRotation = 0f;
    bool isGrounded;
    float groundDistance = 0.4f;


    void Start()
    {
        locomotion.controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        maxStamina = movement.stamina.amount;
    }

    void FixedUpdate()
    {
        if (!movement.isDead)
        {
            Movement();
            Rotation();
        }
    }

    private void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Stamina
        if (Input.GetKey(KeyCode.LeftShift) && movement.stamina.amount > 0 && !recoverAir)
        {
            StopCoroutine(StaminaRecovery_());
            speed = movement.runSpeed;
            recoverStamina = false;
            StartCoroutine(Sprint_());
            sprint = true;
        }
        else
        {
            StartCoroutine(StaminaRecovery_());
            sprint = false;
            speed = movement.walkSpeed;
        }

        //Movement Forward & Sideways
        movement.moveDirecetion = transform.forward * vertical + transform.right * horizontal;
        locomotion.controller.Move(movement.moveDirecetion * speed * Time.deltaTime);

        //Gravity
        isGrounded = Physics.CheckSphere(locomotion.groundCheck.position, groundDistance, locomotion.groundMask);
        velocity.y += -movement.gravity * Time.deltaTime;
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        velocity.y += -movement.gravity * Time.deltaTime;
        locomotion.controller.Move(velocity * Time.deltaTime);
    }

    void Rotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * movement.turnSpeedX * 10 * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * movement.turnSpeedY * 10 * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        locomotion.playerCam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }

    #region - Coroutine -

    IEnumerator Sprint_()
    {
        if (sprint)
        {
            yield break;
        }
        else
        {
            yield return new WaitForSeconds(movement.stamina.loseTime);
            if (movement.stamina.amount > 0)
            {
                sprint = false;
                movement.stamina.amount -= movement.stamina.staminaLose;

                if (movement.stamina.amount < 0)
                {
                    movement.stamina.amount = 0;
                    StartCoroutine(RecoverAir_());
                }
            }
        }
    }

    IEnumerator StaminaRecovery_()
    {
        if (recoverStamina)
        {
            yield break;
        }
        else
        {
            recoverStamina = true;
            yield return new WaitForSeconds(movement.stamina.recoveryTime);
            if (movement.stamina.amount < maxStamina)
            {
                recoverStamina = false;
                movement.stamina.amount += movement.stamina.recoveryAmount;
                if (movement.stamina.amount > maxStamina) { movement.stamina.amount = maxStamina; }
            }
        }
    }

    IEnumerator RecoverAir_()
    {
        if (recoverAir)
        {
            yield break;
        }
        else
        {
            recoverAir = true;
            yield return new WaitForSeconds(movement.stamina.catchBreathTime);
            recoverAir = false;

        }
    }

    #endregion
}
