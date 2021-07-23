using UnityEngine;

public class PlayerControllsScr : MonoBehaviour
{
    PlayerLocomotionScr controlls;
    PlayerControlls inputActions;

    Vector2 movementInput;
    Vector2 rotationInput;

    //ActiveItem
    bool leftActive = false;
    bool rightActive = false;

    private void Start()
    {
        controlls = GetComponent<PlayerLocomotionScr>();
    }

    private void OnEnable()
    {
        if (inputActions == null)
        {
            inputActions = new PlayerControlls();

            inputActions.Player.Walk.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
            inputActions.Player.Rotate.performed += ctx => rotationInput = ctx.ReadValue<Vector2>();
            inputActions.Player.ActivateLeftItem.performed += ctx => HandleLeft();
            inputActions.Player.ActivateRightItem.performed += ctx => HandleRight();
            inputActions.Player.Run.performed += ctx => controlls.isSprint = true;
            inputActions.Player.Run.canceled += ctx => controlls.isSprint = false;
            inputActions.Player.Crouch.performed += ctx => controlls.Crouch();
            inputActions.Player.Crouch.canceled += ctx => controlls.ReleaseCrouch();
            inputActions.Player.Action.performed += ctx => Action();
            inputActions.Player.DropItemLeft.performed += ctx => DropLeft();
            inputActions.Player.DropItemRight.performed += ctx => DropRight();
            inputActions.Player.SwitchItemLeft.performed += ctx => SwitchLeft();
            inputActions.Player.SwitchItemRight.performed += ctx => SwitchRight();
        }

        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    void HandleLeft()
    {
        if (controlls.leftItem)
        {
            leftActive = !leftActive;
        }
    }

    void HandleRight()
    {
        if (controlls.rightItem)
        {
            rightActive = !rightActive;
        }
    }

    private void Update()
    {
        if (!controlls.movement.isDead)
        {
            HandleMovement();
            HandleRotation();
        }

        if (controlls.rightItem)
        {
            if (rightActive) { HandleItemRight(); } else { controlls.DeactivateItem(controlls.rightItem); }
        }
        if (controlls.leftItem)
        {
            if (leftActive) { HandleItemLeft(); } else { controlls.DeactivateItem(controlls.leftItem); }
        }

        Debug.Log("left " + leftActive);
        Debug.Log("right " + rightActive);
    }

    void Action()
    {
        RaycastHit hit;
        var ray = controlls.locomotion.playerCam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, controlls.actionRange, 1 << 8))
        {
            var selection = hit.transform;

            if (selection.transform.tag == "Item")
            {
                controlls.GrabItem(selection);
            }
        }
    }

    void HandleMovement()
    {
        controlls.Movement(movementInput.x, movementInput.y);
    }

    void HandleRotation()
    {
        controlls.Rotation(rotationInput.y, rotationInput.x);
    }

    void HandleItemLeft()
    {
        if (!controlls.leftItem.GetComponent<ItemScr>().item.active && controlls.rightItem)
        {
            if (controlls.leftItem.GetComponent<ItemScr>().item.refillableItem != Item.ItemUsage.none && controlls.rightItem)
            {
                controlls.leftItem.GetComponent<ItemScr>().ActivateItem(controlls.rightItem.GetComponent<ItemScr>().item);
            }
            {
                controlls.leftItem.GetComponent<ItemScr>().ActivateItem();
            }
        }
    }

    void HandleItemRight()
    {
        if (!controlls.rightItem.GetComponent<ItemScr>().item.active && controlls.leftItem)
        {
            if (controlls.rightItem.GetComponent<ItemScr>().item.refillableItem != Item.ItemUsage.none && controlls.leftItem)
            {
                controlls.rightItem.GetComponent<ItemScr>().ActivateItem(controlls.leftItem.GetComponent<ItemScr>().item);
            }
            {
                controlls.rightItem.GetComponent<ItemScr>().ActivateItem();
            }
        }

    }

    void DropLeft()
    {
        if (controlls.isLeftItem) 
        {
            controlls.DropItem(controlls.locomotion.leftHand, controlls.leftItem);
            controlls.isLeftItem = false; 
        }

        leftActive = false;
    }

    void DropRight()
    {
        if (controlls.isRightItem)
        {
            controlls.DropItem(controlls.locomotion.rightHand, controlls.rightItem);
            controlls.isRightItem = false;
        }

        rightActive = false;
    }

    void SwitchLeft()
    {
        controlls.DeactivateItem(controlls.leftItem);
        controlls.SwitchItem(controlls.locomotion.leftHand);
    }

    void SwitchRight()
    {
        controlls.DeactivateItem(controlls.rightItem);
        controlls.SwitchItem(controlls.locomotion.rightHand);
    }
}
