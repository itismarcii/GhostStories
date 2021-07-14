using UnityEngine;

public class PlayerControllsScr : MonoBehaviour
{
    PlayerLocomotionScr controlls;
    PlayerControlls inputActions;

    Vector2 movementInput;
    float verticalInput;
    float horizontalInput;

    private void Awake()
    {
        if(inputActions == null)
        {
            inputActions = new PlayerControlls();

            inputActions.Player.Walk.performed += ctx => movementInput = ctx.ReadValue<Vector2>();

        }

        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    void HandleMovementInput()
    {
        verticalInput = movementInput.x;
        horizontalInput = movementInput.y;
    }
}
