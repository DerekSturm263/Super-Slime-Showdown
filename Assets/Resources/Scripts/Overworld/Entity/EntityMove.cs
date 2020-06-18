using UnityEngine;
using UnityEngine.UI;

public class EntityMove : MonoBehaviour
{
    public enum Direction
    {
        Up, Down, Left, Right
    }
    [HideInInspector] public Direction animDir = Direction.Down;

    public enum State
    {
        Idle, Moving
    }
    [HideInInspector] public State animState = State.Idle;

    protected Rigidbody2D rb2;
    protected Animator anim;
    private Vector2 currentVel;

    [Header("Settings")]
    [SerializeField] [Tooltip("How fast the slime moves.")] private float moveSpeed = 2f;
    [SerializeField] [Tooltip("Scales the slime's speed based on distance from where the original tap was.")] private float moveScaler = 0.5f;

    private Vector2 firstTapPos;

    [Header("UI Images")]
    public Image firstTapIcon;
    public Image heldTapIcon;

    protected void StartMove(Vector2 startPos)
    {
        firstTapPos = Camera.main.ScreenToWorldPoint(startPos);

        firstTapIcon.GetComponent<RectTransform>().anchoredPosition = startPos - new Vector2(Screen.width, Screen.height) / 2f;
        firstTapIcon.GetComponent<CanvasGroup>().alpha = 0.5f;
    }

    protected void Move(Vector2 heldPos, bool isPlayer = false)
    {
        Vector2 moveVal;

        if (isPlayer)
        {
            heldTapIcon.GetComponent<RectTransform>().anchoredPosition = heldPos - new Vector2(Screen.width, Screen.height) / 2f;
            heldTapIcon.GetComponent<CanvasGroup>().alpha = 0.25f;

            // Sets a movement vector based on the position between where your finger started and where it is now.
            moveVal = (Vector2)Camera.main.ScreenToWorldPoint(heldPos) - firstTapPos;
        }
        else
        {
            moveVal = heldPos;
        }

        // Sets an x and a y based on input.
        currentVel.x = Mathf.Lerp(-1f, 1f, moveVal.normalized.x + 0.5f);
        currentVel.y = Mathf.Lerp(-1f, 1f, moveVal.normalized.y + 0.5f);

        // Applys your velocity.
        rb2.velocity = currentVel * moveVal.magnitude * moveSpeed * moveScaler;

        #region Animation States

        // Sets whether you're idle or not.
        animState = (rb2.velocity.magnitude == 0f) ? State.Idle : State.Moving;

        // Sets the direction you're moving in.
        if (Mathf.Abs(rb2.velocity.x) > Mathf.Abs(rb2.velocity.y))
            animDir = (rb2.velocity.x < 0f) ? Direction.Left : Direction.Right;
        else if (Mathf.Abs(rb2.velocity.x) < Mathf.Abs(rb2.velocity.y))
            animDir = (rb2.velocity.y < 0f) ? Direction.Down : Direction.Up;

        // Converts them into animation states.
        anim.SetInteger("State", 1);
        anim.SetInteger("Direction", (int) animDir);

        #endregion
    }

    protected void MoveTowards(GameObject g)
    {
        Vector2 moveVal = new Vector2(g.transform.position.x - transform.position.x, g.transform.position.y - transform.position.y).normalized * moveSpeed;

        // Sets an x and a y based on input.
        currentVel.x = Mathf.Lerp(-1f, 1f, moveVal.normalized.x + 0.5f);
        currentVel.y = Mathf.Lerp(-1f, 1f, moveVal.normalized.y + 0.5f);

        // Applys your velocity.
        rb2.velocity = currentVel * moveVal.magnitude * moveSpeed * moveScaler;

        #region Animation States

        // Sets whether you're idle or not.
        animState = (rb2.velocity.magnitude == 0f) ? State.Idle : State.Moving;

        // Sets the direction you're moving in.
        if (Mathf.Abs(rb2.velocity.x) > Mathf.Abs(rb2.velocity.y))
            animDir = (rb2.velocity.x < 0f) ? Direction.Left : Direction.Right;
        else if (Mathf.Abs(rb2.velocity.x) < Mathf.Abs(rb2.velocity.y))
            animDir = (rb2.velocity.y < 0f) ? Direction.Down : Direction.Up;

        // Converts them into animation states.
        anim.SetInteger("State", (int)animState);
        anim.SetInteger("Direction", (int)animDir);

        #endregion
    }

    protected void StopMove(int tapCount)
    {
        firstTapIcon.GetComponent<CanvasGroup>().alpha = 0f;
        heldTapIcon.GetComponent<CanvasGroup>().alpha = 0f;
        
        // Stops all movement.
        rb2.velocity = Vector2.zero;
        
        // Sets animation state to idle.
        anim.SetInteger("State", 0);
    }
}
