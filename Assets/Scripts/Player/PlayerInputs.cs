using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
    public Vector2 MoveVector { get; private set; }
    public Vector2 ShootVector { get; private set; }

    private InputActions.PlayerActions actions;
    private InputAction moveAction;
    private InputAction shootAction;

    private void OnEnable()
    {
        (actions = new InputActions().Player).Enable();

        (moveAction = actions.Move).Enable();
        (shootAction = actions.Shoot).Enable();

        SubscribeToEvents();
    }

    private void OnDisable()
    {
        actions.Disable();
        moveAction.Disable();
        shootAction.Disable();

        UnsubscribeToEvents();
    }

    private void SubscribeToEvents()
    {
        moveAction.performed += OnMove;
        moveAction.canceled += OnMove;

        shootAction.performed += OnShoot;
        shootAction.canceled += OnShoot;
    }

    private void UnsubscribeToEvents()
    {
        moveAction.performed -= OnMove;
        moveAction.canceled -= OnMove;

        shootAction.performed -= OnShoot;
        shootAction.canceled -= OnShoot;
    }

    private void OnMove(InputAction.CallbackContext ctx)
        => MoveVector = ctx.ReadValue<Vector2>();

    private void OnShoot(InputAction.CallbackContext ctx)
        => ShootVector = ctx.ReadValue<Vector2>();
}