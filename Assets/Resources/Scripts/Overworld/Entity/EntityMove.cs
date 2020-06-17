using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMove : MonoBehaviour
{
    private Rigidbody2D rb2;
    private Vector2 currentVel;

    [SerializeField] private float moveSpeed;

    private void Awake()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    protected void Move(Vector2 movVal)
    {
        currentVel.x = Mathf.Lerp(0f, moveSpeed, movVal.x);
        currentVel.y = Mathf.Lerp(0f, moveSpeed, movVal.y);

        rb2.velocity = currentVel;
    }
}
