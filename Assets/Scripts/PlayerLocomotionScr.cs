using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotionScr : MonoBehaviour
{
    public Player player;

    [System.Serializable]
    public class ToAdd
    {
        public Camera playerCam;
        public Transform groundCheck;
        [HideInInspector] public CharacterController controller;
        public LayerMask groundMask;
        public Transform leftHand;
        public Transform rightHand;
        public GameObject[] items;
        [HideInInspector] public CapsuleCollider collider;
    }

    [Tooltip("Add necessary Objects")] public ToAdd locomotion;
    [Space]

    //Movement Parameter
    private Movement movement;
    Vector3 velocity;
    float speed;
    bool sprint = false;
    bool recoverStamina = false;
    bool recoverAir = false;
    float maxStamina;

    float xRotation = 0f;
    bool isGrounded;
    float groundDistance = 0.4f;

    //Crouching
    bool isCrouching = false;
    float originalheight;

    //Item Parameter
    [Range(1f, 10f)] public float grab_MaxRange = 10f;
    GameObject leftItem;
    GameObject rightItem;
    bool isRightItem = false;
    bool isLeftItem = false;


    void Start()
    {
        movement = player.movement;
        locomotion.controller = GetComponent<CharacterController>();
        locomotion.collider = GetComponent<CapsuleCollider>();
        originalheight = locomotion.collider.height;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        maxStamina = movement.stamina.maxAmount;
        movement.stamina.amount = maxStamina;
    }

    private void Update()
    {
        if (!movement.isDead)
        {
            //Prototype
            if (Input.GetKeyDown(KeyCode.E))
            {
                GrabItem();
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                if(isRightItem) { DropItem(locomotion.rightHand, rightItem); }
                else if(!isLeftItem) { DropItem(locomotion.leftHand, leftItem); }
                
            }
        }
    }

    void FixedUpdate()
    {
        if (!movement.isDead)
        {
            Movement();
            Rotation();
            if(Input.GetKey(KeyCode.LeftControl))
            {
                Crouch();

            }
            else
            {
                ReleaseCrouch();
            }
            
        }
    }


    #region - Movement -
    private void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (!isCrouching)
        {
            //Stamina && Run
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
        }
        else
        {
            speed = movement.crouchSpeed;
        }

        //Movement Forward & Sideways
        movement.moveDirecetion = transform.forward * vertical + transform.right * horizontal;
        locomotion.controller.Move(movement.moveDirecetion * speed * Time.deltaTime);

        Gravity();

        Debug.Log(speed);
    }

    void Gravity()
    {
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

    void Crouch()
    {
        locomotion.controller.height = movement.crouchHeight;
        locomotion.collider.height = movement.crouchHeight;
        isCrouching = true;
    }

    void ReleaseCrouch()
    {
        locomotion.controller.height = originalheight;
        locomotion.collider.height = originalheight;
        isCrouching = false;
    }

    #endregion

    #region - Item -

    void GrabItem()
    {
        RaycastHit hit;
        var ray = locomotion.playerCam.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit, grab_MaxRange))
        {
            var selection = hit.transform;

            if (selection.transform.tag == "Item")
            {
                if (!isRightItem)
                {
                    rightItem = selection.gameObject;
                    rightItem.transform.parent = locomotion.rightHand.parent;
                    rightItem.GetComponent<Rigidbody>().isKinematic = true;
                    rightItem.transform.position = locomotion.rightHand.transform.position;
                    isRightItem = true;
                }
                else if (!isLeftItem)
                {
                    leftItem = selection.gameObject;
                    leftItem.transform.parent = locomotion.leftHand.parent;
                    leftItem.GetComponent<Rigidbody>().isKinematic = true;
                    leftItem.transform.position = locomotion.leftHand.transform.position;
                    isLeftItem = true;
                }
            }
            //Else put into inventory
        }
    }

    void DropItem(Transform parent,GameObject obj)
    {
        obj.transform.parent = null;
        obj.GetComponent<Rigidbody>().isKinematic = false;
        parent = null;
        isRightItem = false;
    }

    #endregion

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
