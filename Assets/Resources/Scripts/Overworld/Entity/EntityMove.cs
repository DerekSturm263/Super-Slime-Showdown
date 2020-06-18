using UnityEngine;
using UnityEngine.UI;

public class EntityMove : MonoBehaviour
{
    public enum Direction
    {
        Up, Down, Left, Right
    }
    [HideInInspector] public Direction animDir;

    public enum State
    {
        Idle, Moving
    }
    [HideInInspector] public State animState;

    protected Rigidbody2D rb2;
    protected Animator anim;
    private Vector2 currentVel;

    [Header("Settings")]
    [SerializeField] private float moveSpeed = 1f;

    private Vector2 firstTapPos;
    private Vector2 movVal;

    public Image debugFirstTap;
    public Image debugContinuousTap;

    protected void StartMove(Vector2 startPos)
    {
        debugFirstTap.GetComponent<RectTransform>().anchoredPosition = startPos;
        debugFirstTap.GetComponent<CanvasGroup>().alpha = 0.5f;
        Debug.Log("First Tap at: " + startPos);

        firstTapPos = startPos;
    }

    protected void Move(Vector2 heldPos)
    {
        debugContinuousTap.GetComponent<RectTransform>().anchoredPosition = heldPos;
        debugContinuousTap.GetComponent<CanvasGroup>().alpha = 0.5f;
        Debug.Log("Held Tap at: " + heldPos);

        movVal = Camera.main.ScreenToWorldPoint(heldPos) - Camera.main.ScreenToWorldPoint(firstTapPos);

        #region Velocity Setting

        // Sets an x and a y based on input.
        currentVel.x = Mathf.Lerp(-moveSpeed, moveSpeed, movVal.x);
        currentVel.y = Mathf.Lerp(-moveSpeed, moveSpeed, movVal.y);

        // Applys your velocity.
        rb2.velocity = currentVel;

        #endregion

        #region Animation States

        // Sets whether you're idle or not.
        animState = (currentVel.magnitude == 0f) ? State.Idle : State.Moving;

        // Sets the direction you're moving in.
        if (Mathf.Abs(currentVel.x) > Mathf.Abs(currentVel.y))
            animDir = (currentVel.x < 0) ? Direction.Left : Direction.Right;
        else if (Mathf.Abs(currentVel.x) < Mathf.Abs(currentVel.y))
            animDir = (currentVel.y < 0) ? Direction.Down : Direction.Up;

        // Converts them into animation states.
        anim.SetInteger("State", (int) animState);
        anim.SetInteger("Direction", (int) animDir);

        #endregion
    }
}
