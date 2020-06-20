using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class PlayerMove : EntityMove
{
    private Controls controls;

    private void Awake()
    {
        controls = new Controls();

        rb2 = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        controls.Player.StartMovement.performed += ctx => StartMove(ctx.ReadValue<Vector2>());
        controls.Player.Movement.performed += ctx => Move(ctx.ReadValue<Vector2>(), true);

        TouchSimulation.Enable();

        maxDist = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).x * 1.25f;
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
