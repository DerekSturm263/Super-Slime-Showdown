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

        maxDist = Screen.width / 1.75f;
    }

    private void Update()
    {
        if (Input.touches.Length > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Ended) StopMove(true);
        }
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
