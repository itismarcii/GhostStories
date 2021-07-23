using System.Collections;
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
    [HideInInspector] public Movement movement;
    Vector3 velocity;
    float speed;
    [HideInInspector] public bool isSprint = false;
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
    InventoryScr inventory;
    [Range(.1f, 5f)] public float actionRange = 10f;
    [HideInInspector] public GameObject leftItem;
    Item item_left;
    [HideInInspector] public GameObject rightItem;
    Item item_right;
    [HideInInspector] public bool isRightItem = false;
    [HideInInspector] public bool isLeftItem = false;


    void Start()
    {
        inventory = GetComponent<InventoryScr>();
        movement = player.movement;
        locomotion.controller = GetComponent<CharacterController>();
        locomotion.collider = GetComponent<CapsuleCollider>();
        originalheight = locomotion.collider.height;
        maxStamina = movement.stamina.maxAmount;
        movement.stamina.amount = maxStamina;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    #region - Movement -
    public void Movement(float horizontal, float vertical)
    {
        if (!isCrouching)
        {
            //Stamina && Run
            if (isSprint && movement.stamina.amount > 0 && !recoverAir)
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

    public void Rotation(float horizontal, float vertical)
    {

        xRotation -= horizontal;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        locomotion.playerCam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * vertical);
    }

    public void Crouch()
    {
        locomotion.controller.height = movement.crouchHeight;
        locomotion.collider.height = movement.crouchHeight;
        isCrouching = true;
    }

    public void ReleaseCrouch()
    {
        locomotion.controller.height = originalheight;
        locomotion.collider.height = originalheight;
        isCrouching = false;
    }

    #endregion

    #region - Item -

    public void GrabItem(Transform selection)
    {

        if (!inventory.InvenotryFull())
        {
            inventory.AddInInventory(selection.GetComponent<ItemScr>().item);

            if (!isRightItem)
            {
                item_right = selection.GetComponent<ItemScr>().item;
                rightItem = selection.gameObject;
                rightItem.transform.parent = locomotion.rightHand;
                rightItem.GetComponent<Rigidbody>().isKinematic = true;
                rightItem.transform.position = locomotion.rightHand.transform.position;
                isRightItem = true;
            }
            else if (!isLeftItem)
            {
                item_left = selection.GetComponent<ItemScr>().item;
                leftItem = selection.gameObject;
                leftItem.transform.parent = locomotion.leftHand;
                leftItem.GetComponent<Rigidbody>().isKinematic = true;
                leftItem.transform.position = locomotion.leftHand.transform.position;
                isLeftItem = true;
            }
            else
            {
                Destroy(selection.gameObject);
            }
        }
    }

    public void DropItem(Transform parent, GameObject obj)
    {
        obj.transform.parent = null;
        obj.GetComponent<Rigidbody>().isKinematic = false;
        parent = null;
        inventory.RemoveFromInventory(obj.GetComponent<ItemScr>().item);
    }

    public void DeactivateItem(GameObject item)
    {
        item.GetComponent<ItemScr>().item.active = false;
    }

    void GenerateItem(GameObject prefab, Item item, Transform parent)
    {
        if (parent == locomotion.leftHand)
        {
            if (leftItem) { Destroy(leftItem); }
            leftItem = Instantiate(prefab, parent);
            leftItem.GetComponent<ItemScr>().item = item;
            item_left = item;
            leftItem.GetComponent<ItemScr>().usage = item.refillableItem;
            leftItem.GetComponent<Rigidbody>().isKinematic = true;
            inventory.AddInInventory(item);
            leftItem.transform.position = parent.position;
            isLeftItem = true;
        }

        if (parent == locomotion.rightHand)
        {
            if(rightItem) { Destroy(rightItem); }
            rightItem = Instantiate(prefab, parent);
            rightItem.GetComponent<ItemScr>().item = item;
            item_right = item;
            rightItem.GetComponent<ItemScr>().usage = item.refillableItem;
            rightItem.GetComponent<Rigidbody>().isKinematic = true;
            inventory.AddInInventory(item);
            rightItem.transform.position = parent.position;
            isRightItem = true;
        }
    }
    

    public void SwitchItem(Transform hand)
    {
        if (inventory.inventory.Count != 0)
        {
            GameObject prefab = null;
            Item item = null;
            foreach (Item i in inventory.inventory)
            {
                if (i != item_left && i != item_right)
                {
                    bool finished = false;

                    foreach (GameObject pre in inventory.prefabs)
                    {

                        if (i.item == pre.GetComponent<ItemScr>().usage)
                        {
                            prefab = pre;
                            item = i;
                            inventory.RemoveFromInventory(i);
                            finished = true;
                            break;
                        }
                    }
                    if (finished) { break; }
                }
            }

            if (prefab && item)
            {
                GenerateItem(prefab, item, hand);
            }
        }
        
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
