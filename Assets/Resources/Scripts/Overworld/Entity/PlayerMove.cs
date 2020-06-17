using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : EntityMove
{
    private Controls controls;

    private override void Awake()
    {
        controls = new Controls();
        rb2 = GetComponent<Rigidbody2D>();

        controls.Player.Movement.performed += ctx => Move(ctx.ReadValue<Vector2>());
    }
}
