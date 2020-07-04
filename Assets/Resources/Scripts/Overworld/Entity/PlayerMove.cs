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
        ps = GetComponent<ParticleSystem>();

        TouchSimulation.Enable();

        controls.Player.StartMovement.performed += ctx => StartMove(ctx.ReadValue<Vector2>());
        controls.Player.Movement.performed += ctx => Move(ctx.ReadValue<Vector2>(), true);
        if (Input.touches[0].phase == TouchPhase.Ended) StopMove();

        maxDist = Screen.width / 1.75f;
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
